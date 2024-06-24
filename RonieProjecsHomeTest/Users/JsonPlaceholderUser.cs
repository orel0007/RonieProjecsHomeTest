using RonieProjecsHomeTest.Users;
using System.Text.Json.Serialization;

namespace RonieProjecsHomeTest.Models
{
    public class JsonPlaceholderUser : User
    {
        [JsonPropertyName("name")]
        public string FullName
        {
            get
            {
                return FirstName;
            }
            set
            {
                var names = value.Split(' ');
                FirstName = names.Length > 0 ? names[0] : string.Empty;
                LastName = names.Length > 1 ? string.Join(' ', names.Skip(1)) : string.Empty;
            }
        }
       public JsonPlaceholderUser()
        {
            //Console.WriteLine("JsonPlaceholderUser");
        }
    }
}
