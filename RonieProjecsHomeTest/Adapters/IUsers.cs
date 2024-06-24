using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.Adapters
{
    internal interface IUsers
    {
        Task<List<Entities.User>> GetUsers();

        Task<Entities.User> GetUser(int id);

        void AddUser(Entities.User user);
    }
}
