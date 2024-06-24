using System.Text.Json.Serialization;

namespace RonieProjecsHomeTest.Adapters.DummyJsonUser.Entities
{
    internal class UsersWrapper
    {
        [JsonPropertyName("users")]
        public List<GetUserResponse> Users { get; set; }
    }
    internal class GetUserResponse
    {
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
    }
}