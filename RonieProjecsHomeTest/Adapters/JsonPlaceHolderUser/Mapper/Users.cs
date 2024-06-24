
using RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Enitites;

namespace RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Mapper
{
    internal static class UsersMapper
    {
        public static Entities.User Map(this GetUserResponse user)
        {
            return new Entities.User
            {
                FirstName = user.Name.Split(' ')[0],
                LastName = user.Name.Split(' ').Last(),
                Email = user.Email,
                SourceId = Client.SourceId
            };
        }
    }
}
