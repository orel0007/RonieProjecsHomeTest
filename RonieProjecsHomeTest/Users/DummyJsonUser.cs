using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Users
{
    public class DummyJsonUser : User
    {
        [JsonPropertyName("firstName")]
        public string JsonFirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        [JsonPropertyName("lastName")]
        public string JsonLastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
    }
}
