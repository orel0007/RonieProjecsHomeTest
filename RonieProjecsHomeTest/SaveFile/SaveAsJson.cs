using RonieProjecsHomeTest.Users;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace RonieProjecsHomeTest.SaveFile
{
    public  class SaveAsJson: Isave
    {
        public void Save(String path, List<User> users)
        {
            var jsonString = JsonSerializer.Serialize(users);
            File.WriteAllTextAsync(path, jsonString);
        }
    }
}
