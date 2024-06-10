using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Models;
using RonieProjecsHomeTest.Users;
using RonieProjecsHomeTest.Fetch;
using System.Diagnostics;


namespace RonieProjecsHomeTest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            List<User> users = new List<User>(); // List to hold all fetched users
            FetchUsers fetchUsers = new FetchUsers();
/*            users.AddRange(await fetchUsers.FetchRandomUserApiAsync());
            users.AddRange(await fetchUsers.FetchJsonPlaceholderUsersAsync());
            users.AddRange(await fetchUsers.FetchDummyJsonUsersAsync());
            users.AddRange(await fetchUsers.FetchReqresUsersAsync());*/
            var fetchTasks = new[]
        {
            fetchUsers.FetchRandomUserApiAsync(),
            fetchUsers.FetchJsonPlaceholderUsersAsync(),
            fetchUsers.FetchDummyJsonUsersAsync(),
            fetchUsers.FetchReqresUsersAsync()
        };

            var results = await Task.WhenAll(fetchTasks);

            // Add all fetched users to the list
            foreach (var result in results)
            {
                users.AddRange(result);
            }
            Console.WriteLine($"Total users fetched: {users.Count}");
            
            stopwatch.Stop();
            // Display the elapsed time
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");

            Console.WriteLine("stop here");
        }
    }
}
