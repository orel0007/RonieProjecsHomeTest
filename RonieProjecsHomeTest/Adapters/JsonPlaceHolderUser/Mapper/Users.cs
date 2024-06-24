
using RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Enitites;

namespace RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Mapper
{
    internal static class UsersMapper
    {
        public static Entities.User Map(this GetUserResponse user)
        {
            return new Entities.User
            {
                FirstName = user.name.Split(' ')[0],
                LastName = user.name.Split(' ').Last(),
                Email = user.email,
                SourceId = Client.SourceId
            };
        }
    }
}
