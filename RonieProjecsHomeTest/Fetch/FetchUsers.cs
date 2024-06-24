using RonieProjecsHomeTest.Users;
using RonieProjecsHomeTest.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace RonieProjecsHomeTest.Fetch
{
    public class FetchUsers
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<IEnumerable<User>> FetchRandomUserApiAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<JsonElement>("https://randomuser.me/api/?results=500");
                return response.GetProperty("results").EnumerateArray().Select(json =>
                {
                    var user = JsonSerializer.Deserialize<RandomUser>(json.ToString());
                    user.SourceId = 1; // RandomUser
                    return user as RandomUser;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching RandomUser API: {ex.Message}");
                return Enumerable.Empty<User>();
            }
        }

        public async Task<IEnumerable<User>> FetchJsonPlaceholderUsersAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<JsonElement[]>("https://jsonplaceholder.typicode.com/users");
                return response.Select(json =>
                {
                    var user = JsonSerializer.Deserialize<JsonPlaceholderUser>(json.ToString());
                    user.SourceId = 2; // JsonPlaceholder
                    return user as JsonPlaceholderUser;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching JsonPlaceholder API: {ex.Message}");
                return Enumerable.Empty<User>();
            }
        }

        public async Task<IEnumerable<User>> FetchDummyJsonUsersAsync()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<JsonElement>("https://dummyjson.com/users");
                return response.GetProperty("users").EnumerateArray().Select(json =>
                {
                    var user = JsonSerializer.Deserialize<DummyJsonUser>(json.ToString());
                    user.SourceId = 3; // DummyJson
                    return user as DummyJsonUser;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching DummyJson API: {ex.Message}");
                return Enumerable.Empty<User>();
            }
        }

        public async Task<IEnumerable<User>> FetchReqresUsersAsync()
        {
            var users = new List<User>();
            int currentPage = 1;
            int totalPages;
            try
            {
                do
                {
                    var response = await _httpClient.GetFromJsonAsync<ReqresList>($"https://reqres.in/api/users?page={currentPage}");
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching Reqres API: {ex.Message}");
                return users;
            }
        }
    }
}
