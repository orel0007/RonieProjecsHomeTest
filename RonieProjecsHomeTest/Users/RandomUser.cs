using System.Text.Json.Serialization;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.Models
{
    public class RandomUser : User
    {
        [JsonPropertyName("name")]
        public Name? Name {  get; set; }
        public RandomUser(Name name, string email) 
        {
 
            //Console.WriteLine("RandomUser");

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
