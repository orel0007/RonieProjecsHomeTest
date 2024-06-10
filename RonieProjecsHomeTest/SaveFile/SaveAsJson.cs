using RonieProjecsHomeTest.Users;
using System.Text.Json;
using System.Text.Json.Serialization;


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
