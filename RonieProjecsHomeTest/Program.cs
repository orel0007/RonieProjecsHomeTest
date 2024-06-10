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
using RonieProjecsHomeTest.SaveFile;


namespace RonieProjecsHomeTest
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            UsersService usersService = new UsersService();
            usersService.GetUserInputs();

            List<User> users = new List<User>(); // List to hold all fetched users
            FetchUsers fetchUsers = new FetchUsers();
 
            var fetchTasks = new[]{
            fetchUsers.FetchRandomUserApiAsync(),
            fetchUsers.FetchJsonPlaceholderUsersAsync(),
            fetchUsers.FetchDummyJsonUsersAsync(),
            fetchUsers.FetchReqresUsersAsync()
            /*for add new fetch need 1) cretae new user derive from user if is data store diffrently for serilzaion.
                 2) crate fetch funtion in fetch users 3) add here 1 code line of the ftech funtion. */
            };

            var results = await Task.WhenAll(fetchTasks);

            // Add all fetched users to the list
            foreach (var result in results)
            {
                users.AddRange(result);
            }
            Console.WriteLine($"Total users fetched: {users.Count}");

            await usersService.SaveUsersAsync(users);

            stopwatch.Stop();
   
            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");

        }
    }
}
