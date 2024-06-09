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



namespace RonieProjecsHomeTest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {

            List<User> users = new List<User>();
            
            Console.WriteLine($"Total users fetched: {users.Count}");
        }
    }
}
