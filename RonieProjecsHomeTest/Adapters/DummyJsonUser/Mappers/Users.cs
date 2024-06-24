using System.Collections.Generic;
using System.Linq;
using RonieProjecsHomeTest.Adapters.DummyJsonUser.Entities;
using RonieProjecsHomeTest.Entities;

namespace RonieProjecsHomeTest.Adapters.DummyJsonUser.Mappers
{
    internal static class Users
    {
        public static User Map(this GetUserResponse user)
        {
            return new User
            {
                FirstName = user.firstName,
                LastName = user.lastName,
                Email = user.email,
                SourceId = Client.SourceId
            };
        }

        public static List<User> Map(this List<GetUserResponse> users)
        {
            return users?.Select(user => user.Map()).ToList() ?? new List<User>();
        }
    }
}
