namespace RonieProjecsHomeTest.Adapters.ReqresUser.Entities
{
    public class GetUsersResponse
    {
        public int total_pages { get; set; }
        public List<Data> data { get; set; }
    }

    public class Data
    {
        public string email { get; set; } = string.Empty;
        public string first_name { get; set; } = string.Empty;
        public string last_name { get; set; } = string.Empty;
    }
}
