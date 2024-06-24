using RonieProjecsHomeTest.Validations;
using System;

namespace RonieProjecsHomeTest.Handlers
{
    public static class HandlerUserInput
    {
        private const string DefaultFileFormat = "json";
        private const string DefaultFolderPath = @"C:\Users\orela\OneDrive\Desktop";

        public static string UserInputHandler(string prompt, string defaultStr, Action<string> validationAction)
        {
            
            int errorCount = 0;
            string userInput = null;
            bool isValid = false;

            while (!isValid && errorCount < 2)
            {
                try
                {
                    Console.WriteLine(prompt);
                    userInput = Console.ReadLine();
                    validationAction(userInput); // This will throw an exception if validation fails
                    isValid = true;
                }
                catch (Exception ex)
                {
                    errorCount++;
                    if (errorCount >= 2)
                    {
                        Console.WriteLine($"Too many errors. Using default value: {defaultStr}");
                        userInput = defaultStr;
                        isValid = true;
                    }
                    else
                        Console.WriteLine($"Error: {ex.Message}");

                }
            }

            return userInput;
        }

        public static (string, string) GetUserInputs(bool deafult)
        {
            if (deafult)
                return (DefaultFileFormat, DefaultFolderPath);
            string fileFormat = UserInputHandler(
                "Enter file format (json or csv): ",
                DefaultFileFormat,
                ValidationUsersInput.ValidateFormat
            );

            string folderPath = UserInputHandler(
                "Enter folder path: ",
                DefaultFolderPath,
                ValidationUsersInput.ValidatePath
            );

            return (fileFormat, folderPath);
        }
    }
}