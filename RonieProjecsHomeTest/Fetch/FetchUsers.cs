using RonieProjecsHomeTest.Users;
using RonieProjecsHomeTest.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RonieProjecsHomeTest.Fetch
{
    public class FetchUsers
    {
        private readonly HttpClient _httpClient;

        public FetchUsers()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<User>> FetchRandomUserApiAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<JsonElement>("https://randomuser.me/api/?results=500");
            return response.GetProperty("results").EnumerateArray().Select(json =>
            {
                var user = JsonSerializer.Deserialize<RandomUser>(json.ToString());
                user.SourceId = 1; // RandomUser
                return user as RandomUser;
            });
        }

        public async Task<IEnumerable<User>> FetchJsonPlaceholderUsersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<JsonElement[]>("https://jsonplaceholder.typicode.com/users");
            return response.Select(json =>
            {
                var user = JsonSerializer.Deserialize<JsonPlaceholderUser>(json.ToString());
                user.SourceId = 2; // JsonPlaceholder
                return user as JsonPlaceholderUser;
            });
        }

        public async Task<IEnumerable<User>> FetchDummyJsonUsersAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<JsonElement>("https://dummyjson.com/users");
            return response.GetProperty("users").EnumerateArray().Select(json =>
            {
                var user = JsonSerializer.Deserialize<DummyJsonUser>(json.ToString());
                user.SourceId = 3; // DummyJson
                return user as DummyJsonUser;
            });
        }

        public async Task<IEnumerable<User>> FetchReqresUsersAsync()
        {

            var users = new List<User>();
            int currentPage = 1;
            int totalPages;
            do
            {
                var response = await _httpClient.GetFromJsonAsync<ReqreList>($"https://reqres.in/api/users?page={currentPage}");
                totalPages = response.TotalPages;

                users.AddRange(response.Data.Select(reqresUser => new ReqresUser
                {
                    FirstName = reqresUser.FirstName,
                    LastName = reqresUser.LastName,
                    Email = reqresUser.Email,
                    SourceId = 4 // Reqres
                }));

                currentPage++;
            } while (currentPage <= totalPages);

            return users;

        }
    }  
}
