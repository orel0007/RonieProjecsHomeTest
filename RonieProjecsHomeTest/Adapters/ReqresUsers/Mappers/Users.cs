
namespace RonieProjecsHomeTest.Adapters.ReqresUsers.Mappers
{
    internal static class Users
    {
        public static RonieProjecsHomeTest.Entities.User Map(this RonieProjecsHomeTest.Adapters.ReqresUsers.Entities.Data data)
        {
            return new RonieProjecsHomeTest.Entities.User
            {
                FirstName = data.first_name,
                LastName = data.last_name,
                Email = data.email,
                SourceId = Client.SourceId
            };
        }
    }
}
