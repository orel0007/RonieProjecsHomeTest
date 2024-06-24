using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.SaveFile
{
    public class SaveAsJson : ISaveFile
    {
        public async Task SaveAsync(string path, List<User> users)
        {
            try
            {
                var jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions
                {
                    WriteIndented = true // Optional: makes the JSON output more readable
                });
                await File.WriteAllTextAsync(path, jsonString);
                Console.WriteLine("Users saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving users to file: {ex.Message}");
            }
        }
    }
}
