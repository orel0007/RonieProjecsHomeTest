using System.Text.Json.Serialization;

namespace RonieProjecsHomeTest.Users
{
    public class User
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
        public int SourceId { get; set; } = int.MinValue;
    }
}
