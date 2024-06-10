using RonieProjecsHomeTest.Models;
using System.Text.Json.Serialization;


namespace RonieProjecsHomeTest.Users
{
    public class ReqreList
    {

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<ReqresUser> Data { get; set; }
    }
}
