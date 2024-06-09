using RonieProjecsHomeTest.Users;
using System.Text.Json.Serialization;
using RonieProjecsHomeTest.Models;

namespace RonieProjecsHomeTest.Models
{
    public class JsonPlaceholderUser : User
    {
        [JsonPropertyName("name")]
        public string FullName {  get; set; }
        }
    }
}
