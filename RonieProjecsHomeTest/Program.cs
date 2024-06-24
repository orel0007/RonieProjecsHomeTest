using RonieProjecsHomeTest.Adapters;
using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.Fetch;
using RonieProjecsHomeTest.SaveFile;
using System.Diagnostics;


namespace RonieProjecsHomeTest
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            (var fileFormat, var folderPath) = GetUserInputs();

            var handlers = GetUserHandlers();

            var tasks = handlers.Select(handler => handler.GetUsers()).ToList();

            await Task.WhenAll(tasks);

            var users = tasks.SelectMany(task => task.Result).ToList();

            UsersService usersService = new UsersService();//delete
            //await usersService.SaveUsersAsync(users);//dwlwtw
            //var saveFile = new SaveFileService(fileFormat, folderPath);
            Console.WriteLine($"Total users fetched: {users.Count}");
            stopwatch.Stop();

            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        }

        /// <summary>
        /// Gets user inputs from the console.
        /// </summary>
        /// <returns>The first item is a file format (json, csv). The second one is a folder path.</returns>
        private static (string, string) GetUserInputs()
        {
            // todo: add validation for file format and folder path
            // todo: add default values for file format and folder path
            // todo: add error handling
            // todo: add retry logic

            Console.WriteLine("Enter file format (json or csv): ");
            string fileFormat = Console.ReadLine();

            Console.WriteLine("Enter folder path: ");
            string folderPath = Console.ReadLine();

            return (fileFormat, folderPath);
        }

        private static List<IUsers> GetUserHandlers()
        {
            return new List<IUsers>
            {
                new RonieProjecsHomeTest.Adapters.RandomUser.Client(),
                new RonieProjecsHomeTest.Adapters.JsonPlaceHolderUser.Client(),
                new RonieProjecsHomeTest.Adapters.DummyJsonUser.Client(),
                new RonieProjecsHomeTest.Adapters.ReqresUsers.Client()

            };
        }
    }
}
