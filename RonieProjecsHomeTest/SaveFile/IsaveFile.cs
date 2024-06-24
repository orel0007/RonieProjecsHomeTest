using System.Collections.Generic;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Entities;

namespace RonieProjecsHomeTest.SaveFile
{
    public interface ISaveFile
    {
        Task SaveAsync(string path, List<User> users);
    }
}
