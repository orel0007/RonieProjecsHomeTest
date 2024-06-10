using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.SaveFile
{
    public class SaveAsCsv : ISaveFile
    {
        public async Task SaveAsync(string path, List<User> users)
        {
            using var writer = new StreamWriter(path);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            await csv.WriteRecordsAsync(users);
        }
    }
}
