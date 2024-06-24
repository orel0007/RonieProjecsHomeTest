using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Adapters.RandomUser.Entities
{
    internal class GetUsersResponse
    {
        public Result[] results { get; set; }
    }



    public class Result
    {
        public Name name { get; set; }
        public string email { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
        public string last { get; set; }
    }
}
