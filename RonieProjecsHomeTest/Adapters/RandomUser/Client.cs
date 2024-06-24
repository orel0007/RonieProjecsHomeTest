using RonieProjecsHomeTest.Adapters.RandomUser.Entities;
using RonieProjecsHomeTest.Adapters.RandomUser.Mappers;
using RonieProjecsHomeTest.Entities;
using System.Text.Json;


namespace RonieProjecsHomeTest.Adapters.RandomUser
{
    internal class Client : IUsers
    {
        private const string baseUrl = "https://randomuser.me/api/?results=500";
        internal static int SourceId = 1;
        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUser(int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(baseUrl);
                var json = await response.Content.ReadAsStringAsync();

                var user = JsonSerializer.Deserialize<GetUsersResponse>(json.ToString()).results.First();

                return user.Map();                
            }
        }

        public async Task<List<User>> GetUsers()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(baseUrl);
                var json = await response.Content.ReadAsStringAsync();

                var users = JsonSerializer.Deserialize<GetUsersResponse>(json.ToString());

                return users.results.Select(Mappers.Users.Map).ToList();
            }
        }
    }
}
