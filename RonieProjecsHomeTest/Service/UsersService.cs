using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.SaveFile
{
    public class UsersService
    {
        public string FilePath { get; set; } = string.Empty;
        public string FileFormat { get; set; } = string.Empty;
        public string SaveFilePath { get; set; } = string.Empty;

        public void GetUserInputs()
        {
            Console.Write("Enter the folder path to save the file: ");
            try
            {
                FilePath = Console.ReadLine();
                ValidatePath(FilePath);

                Console.Write("Enter the desired file format (json/csv): ");
                FileFormat = Console.ReadLine().ToLower();
                ValidateFormat(FileFormat);

                // Proceed with saving the file using the validated FilePath and FileFormat
                Console.WriteLine($"Saving file to: {FilePath} as {FileFormat} format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Environment.Exit(1);
            }
        }

        public async Task SaveUsersAsync(List<User> users)
        {
            SaveFilePath = Path.Combine(FilePath, $"users.{FileFormat}");
            if (FileFormat == "json")
            {
                SaveAsJson saveJson = new SaveAsJson();
                await saveJson.SaveAsync(SaveFilePath, users);
            }
            else if (FileFormat == "csv")
            {
                SaveAsCsv saveCsv = new SaveAsCsv();
                await saveCsv.SaveAsync(SaveFilePath, users);
            }
        }

        public void ValidatePath(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("The folder path cannot be null or empty.");

            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("The specified folder path does not exist.");
        }

        public void ValidateFormat(string format)
        {
            if (format != "json" && format != "csv")
            {
                throw new InvalidFileFormatException("Invalid file format. Please enter 'json' or 'csv'.");
            }
        }
    }

    public class InvalidFileFormatException : Exception
    {
        public InvalidFileFormatException(string message) : base(message) { }
    }
}
