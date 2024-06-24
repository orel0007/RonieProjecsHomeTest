using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using CsvHelper;
using RonieProjecsHomeTest.Entities;

namespace RonieProjecsHomeTest.SaveFile.SaveCsv
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
