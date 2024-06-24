using RonieProjecsHomeTest.Exceptions;

namespace RonieProjecsHomeTest.Validations
{
    internal class ValidationUsersInput
    {
        public static void ValidatePath(string path)
        {
            ValidateNullEmpty(path, "The folder path cannot be null or empty.");
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("The specified folder path does not exist.");
        }

        public static void  ValidateFormat(string format)
        {
            ValidateNullEmpty(format, "The format cannot be null or empty. Please enter 'json' or 'csv'");
            if (format != "json" && format != "csv")
            {
                throw new InvalidFileFormatException("Invalid file format. Please enter 'json' or 'csv'.");
            }
        }

        public static void ValidateNullEmpty(string str, string massage)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentNullException(massage);
        }
    }
}
