using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.Adapters.ReqresUser.Entities;

namespace RonieProjecsHomeTest.Adapters.ReqresUser.Mappers
{
    public static class UsersMapper
    {
        public static User Map(this Data data)
        {
            return new User
            {
                FirstName = data.First_name,
                LastName = data.Last_name,
                Email = data.Email,
                SourceId = Client.SourceId
            };
        }
    }
}