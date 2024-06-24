
namespace RonieProjecsHomeTest.Adapters.DummyJsonUser.Mappers
{
    internal static class Users
    {
        public static RonieProjecsHomeTest.Entities.User Map(this RonieProjecsHomeTest.Adapters.DummyJsonUser.Entities.GetUserResponse user)
        {
            return new RonieProjecsHomeTest.Entities.User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                SourceId = Client.SourceId
            };
        }
        public static List<RonieProjecsHomeTest.Entities.User> Map(this List<RonieProjecsHomeTest.Adapters.DummyJsonUser.Entities.GetUserResponse> users)
        {
            return users.Select(user => user.Map()).ToList();
        }

    }
}
