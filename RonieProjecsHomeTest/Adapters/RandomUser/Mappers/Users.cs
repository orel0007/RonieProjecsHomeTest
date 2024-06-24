
namespace RonieProjecsHomeTest.Adapters.RandomUser.Mappers
{
    internal static class Users
    {
        public static RonieProjecsHomeTest.Entities.User Map(this RandomUser.Entities.Result result)
        {
            return new RonieProjecsHomeTest.Entities.User
            {
                FirstName = result.name.first,
                LastName = result.name.last,
                Email = result.email,
                SourceId = Client.SourceId
            };
        }
    }
}
