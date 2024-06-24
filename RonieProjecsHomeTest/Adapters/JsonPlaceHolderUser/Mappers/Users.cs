using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Mappers
{
    internal static class Users
    {
        public static RonieProjecsHomeTest.Entities.User Map(this RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Entities.GetUserResponse user)
        {
            return new RonieProjecsHomeTest.Entities.User
            {
                FirstName = user.FullName.Split(' ')[0],
                LastName = user.FullName.Split(' ').Last(),
                Email = user.Email,
                SourceId = Client.SourceId
            };
        }

        public static List<RonieProjecsHomeTest.Entities.User> Map(this List<RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Entities.GetUserResponse> users)
        {
            return users.Select(user => user.Map()).ToList();
        }
    }
}
