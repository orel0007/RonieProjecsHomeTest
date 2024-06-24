using RonieProjecsHomeTest.Adapters.RandomUser;
using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.Adapters.ReqresUsers.Entities;
using RonieProjecsHomeTest.Adapters.ReqresUsers.Mappers;
using System.Text.Json;

namespace RonieProjecsHomeTest.Adapters.ReqresUsers
{

    internal class Client : IUsers
    {
        private const string baseUrl = "https://reqres.in/api/users";
        internal static int SourceId = 4;
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }
        public async Task<User> GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{baseUrl}/{id}");
                if (!response.IsSuccessStatusCode)
                {
                    // Handle response error
                    throw new Exception($"Error fetching user with id {id}: {response.ReasonPhrase}");
                }

                var json = await response.Content.ReadAsStringAsync();
                var userResponse = JsonSerializer.Deserialize<GetUsersResponse>(json);
                var user = userResponse?.data.FirstOrDefault();

                return user?.Map() ?? new User(); // Return mapped user or a new empty user if null
            }
        }

        public async Task<List<User>> GetUsers()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{baseUrl}?per_page=12");
                var json = await response.Content.ReadAsStringAsync();
                var usersResponse = JsonSerializer.Deserialize<GetUsersResponse>(json);
                return usersResponse?.data.Select(data => data.Map()).ToList() ?? new List<User>();
            }
        }
    }
}
