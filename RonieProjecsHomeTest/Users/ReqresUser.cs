using RonieProjecsHomeTest.Users;
using System.Text.Json.Serialization;
using RonieProjecsHomeTest.Models;

namespace RonieProjecsHomeTest.Models
{
    public class ReqresUser : User
    {
        [JsonPropertyName("first_name")]
        public string JsonFirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        [JsonPropertyName("last_name")]
        public string JsonLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public ReqresUser()
        {
            Console.WriteLine("ReqresUser");
        }
    }
}
