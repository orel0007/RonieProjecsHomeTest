using RonieProjecsHomeTest.Entities;

namespace RonieProjecsHomeTest.SaveFile
{
    public interface ISaveFile
    {
        Task SaveAsync(string path, List<User> users);
    }
}
