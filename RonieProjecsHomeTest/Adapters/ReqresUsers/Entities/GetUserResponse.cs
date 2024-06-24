namespace RonieProjecsHomeTest.Adapters.ReqresUsers.Entities
{
    internal class GetUsersResponse
    {
        public List<Data> data { get; set; }
    }

    public class Data
    {
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}
