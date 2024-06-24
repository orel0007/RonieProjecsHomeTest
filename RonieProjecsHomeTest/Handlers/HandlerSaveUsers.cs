using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.SaveFile;
using RonieProjecsHomeTest.SaveFile.SaveCsv;

namespace RonieProjecsHomeTest.Handlers
{
    public class HandlerSaveUsers
    {
        public static async Task SaveUsersAsync(List<User> users, string folderPath, string fileFormat)
        {
            string SaveFilePath = Path.Combine(folderPath, $"users.{fileFormat}");
            if (fileFormat == "json")
            {
                SaveAsJson saveJson = new SaveAsJson();
                await saveJson.SaveAsync(SaveFilePath, users);
            }
            else if (fileFormat == "csv")
            {
                SaveAsCsv saveCsv = new SaveAsCsv();
                await saveCsv.SaveAsync(SaveFilePath, users);
            }
            Console.WriteLine("finish save");
        }
    }

}