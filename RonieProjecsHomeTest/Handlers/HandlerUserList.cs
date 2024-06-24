using RonieProjecsHomeTest.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Handlers
{
    internal class HandlerUserList
    {
        public static List<IUsers> GetUserHandlers()
        {
            return new List<IUsers>
            {
                new Adapters.RandomUser.Client(),
                new Adapters.JsonPlaceHolderUser.Client(),
                new Adapters.DummyJsonUser.Client(),
                new Adapters.ReqresUser.Client()
            };

        }
    }

}
