using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.SaveFile.SaveCsv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RonieProjecsHomeTest.SaveFile
{
    public class SaveUtil
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
