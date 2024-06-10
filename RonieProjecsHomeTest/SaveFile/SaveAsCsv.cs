using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.SaveFile
{
    public class SaveAsCsv : Isave
    {
        public void Save(string path, List<User> users)
        {
            try
            {
                using (var writer = new StreamWriter(path))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(users);
                }
                Console.WriteLine("File saved successfully.");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error: Access to the path is denied. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
