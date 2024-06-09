using CsvHelper.Configuration;
using CsvHelper;
using RonieProjecsHomeTest.Users;
using System.Globalization;
using System.Text.Json;

namespace RonieProjecsHomeTest.SaveFile
{
    public class SaveAsCsv : Isave
    {
        public void Save(String path, List<User> users)
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(users);
            }
        }
    }
}
