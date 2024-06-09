using RonieProjecsHomeTest.Users;
using System.Text.Json;

namespace RonieProjecsHomeTest.SaveFile
{
    public  class SaveAsJson: Isave
    {
        public void Save(String path, List<User> users)
        {

            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
    }

}
