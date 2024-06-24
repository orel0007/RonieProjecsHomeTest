
﻿using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Adapters.DummyJsonUser.Entities;
using RonieProjecsHomeTest.Adapters.DummyJsonUser.Mappers;
using RonieProjecsHomeTest.Entities;

namespace RonieProjecsHomeTest.Adapters.DummyJsonUser
{
    internal class Client : IUsers
    {
        private const string baseUrl = "https://jsonplaceholder.typicode.com/users";
        internal static int SourceId = 3;

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
                var user = JsonSerializer.Deserialize<GetUserResponse>(json);
                return user?.Map();
            }
        }

        public async Task<List<User>> GetUsers()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(baseUrl);
                var json = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<GetUserResponse>>(json);
                return users?.Map() ?? new List<User>();
            }
        }
    }
}
