using RonieProjecsHomeTest.Users;

namespace RonieProjecsHomeTest.SaveFile
{
    public class UsersService
    {
        public string FilePath { get; set; } = string.Empty;
        public string FileFormat { get; set; } = string.Empty;

        public string SaveFilePath { get; set; } = string.Empty;

        public async Task GetUserInputsAsync()
        {
            Console.Write("Enter the folder path to save the file: ");
            try
            {

                FilePath = await Task.Run(() => Console.ReadLine());

                ValidatePath(FilePath);
        
                Console.Write("Enter the desired file format (json/csv): ");
                FileFormat = (await Task.Run(() => Console.ReadLine()))?.ToLower();
                ValidateFormat(FileFormat);
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

        public void checkNull(string path, string massage)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(massage);
        }
        public void ValidatePath(string path)
        {
            checkNull(path, "The folder path cannot be null or empty.");
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("The specified folder path does not exist.");
        }

        public void ValidateFormat(string format) {
            checkNull(format, "The format path cannot be null or empty. Nedd to be 'json' or 'csv'.");
            if (format != "json" && format != "csv")
                throw new InvalidFileFormatException("Invalid file format. Please enter 'json' or 'csv'.");
        }

    }
}
