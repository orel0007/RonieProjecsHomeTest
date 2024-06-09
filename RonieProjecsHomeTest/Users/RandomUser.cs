using System;
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
        public Name Name {  get; set; }

    }

    public class Name
    {
        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }
    }

}
