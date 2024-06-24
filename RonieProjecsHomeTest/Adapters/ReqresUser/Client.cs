using RonieProjecsHomeTest.Adapters.ReqresUser.Entities;
using RonieProjecsHomeTest.Adapters.ReqresUser.Mappers;
using RonieProjecsHomeTest.Entities;
using System.Text.Json;


namespace RonieProjecsHomeTest.Adapters.ReqresUser
{
    internal class Client : IUsers
    {
        private const string baseUrl = "https://reqres.in/api/users";
        internal static int SourceId = 2;

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{baseUrl}/{id}");
                var json = await response.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<RonieProjecsHomeTest.Adapters.ReqresUser.Entities.Data>(json);
                return user?.Map();
            }
        }

        public async Task<List<User>> GetUsers()
        {
            var allUsers = new List<User>();
            int page = 1;

            using (var client = new HttpClient())
            {
                while (true)
                {
                    var response = await client.GetAsync($"{baseUrl}?page={page}");
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception("Error fetching users: " + response.ReasonPhrase);
                    }

                    var json = await response.Content.ReadAsStringAsync();
                    var usersResponse = JsonSerializer.Deserialize<GetUsersResponse>(json);

                    if (usersResponse?.data == null || !usersResponse.data.Any())
                    {
                        break;
                    }

                    allUsers.AddRange(usersResponse.data.Select(user => user.Map()));

                    if (page >= usersResponse.total_pages)
                    {
                        break;
                    }

                    page++;
                }
            }

            return allUsers;
        }
    }
}
