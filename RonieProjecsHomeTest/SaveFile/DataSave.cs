using CsvHelper;
using RonieProjecsHomeTest.Users;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Models;

namespace RonieProjecsHomeTest.SaveFile
{
    public class DataSave
    {
        public string filePath { get; set; } = string.Empty;
        public string fileFormat { get; set; } = string.Empty;
        public string saveFilePath { get; set; } = string.Empty;
        public void GetUserInputs()
        {
            Console.Write("Enter the folder path to save the file: ");
            try
            {
                filePath = Console.ReadLine();
                ValidatePath(filePath);

                Console.Write("Enter the desired file format (json/csv): ");
                fileFormat = Console.ReadLine().ToLower();
                ValidateFormat(fileFormat);

                // Proceed with saving the file using the validated filePath and fileFormat
                Console.WriteLine($"Saving file to: {filePath} as {fileFormat} format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Environment.Exit(1);
            }
        }

        public void SaveUsers(List<User> users)
        {
            saveFilePath = Path.Combine(filePath, $"users.{fileFormat}");
            if (fileFormat == "json")
            {
                SaveAsJson saveJasons = new SaveAsJson();
                saveJasons.Save(saveFilePath, users);
            }
            else if (fileFormat == "csv")
            {
                SaveAsCsv saveCsv = new SaveAsCsv();
                saveCsv.Save(saveFilePath, users);
            }
        }

        public void ValidatePath(string path)
        {
            if (string.IsNullOrEmpty(filePath))
                throw new ArgumentNullException("The folder path cannot be null or empty.");

            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("The specified folder path does not exist.");
        }

        public void ValidateFormat(string format)
        {
            if (fileFormat != "json" && fileFormat != "csv")
            {
                throw new InvalidFileFormatException("Invalid file format. Please enter 'json' or 'csv'.");
            }
        }
    }


}
