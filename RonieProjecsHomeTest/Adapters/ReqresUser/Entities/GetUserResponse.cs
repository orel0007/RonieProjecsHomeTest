namespace RonieProjecsHomeTest.Adapters.ReqresUser.Entities
{
    public class GetUsersResponse
    {
        public int total_pages { get; set; }
        public List<Data> data { get; set; }
    }

    public class Data
    {
        public string Email { get; set; } = string.Empty;
        public string First_name { get; set; } = string.Empty;
        public string Last_name { get; set; } = string.Empty;
    }
}
