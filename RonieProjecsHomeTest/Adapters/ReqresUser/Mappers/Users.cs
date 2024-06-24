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
                FirstName = data.first_name,
                LastName = data.last_name,
                Email = data.email,
                SourceId = Client.SourceId
            };
        }
    }
}