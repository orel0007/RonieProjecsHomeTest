﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.Models
{
    public class RandomUser : User
    {
        [JsonPropertyName("name")]
        public Name Name {  get; set; } = new Name();
        public RandomUser(Name name, string email) 
        {
 
            Console.WriteLine("RandomUser");

            FirstName = name.First;
            LastName = name.Last;
            Email = email;
        }
    }

    public class Name
    {
        [JsonPropertyName("first")]
        public string First { get; set; } = string.Empty;

        [JsonPropertyName("last")]
        public string Last { get; set; } = string.Empty;
    }

}
