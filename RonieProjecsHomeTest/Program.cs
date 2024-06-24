
using System.Diagnostics;
using RonieProjecsHomeTest.Adapters;
using RonieProjecsHomeTest.Entities;
using RonieProjecsHomeTest.SaveFile.SaveCsv;
using RonieProjecsHomeTest.SaveFile;
using RonieProjecsHomeTest.Validations;
using RonieProjecsHomeTest.Handlers;

namespace RonieProjecsHomeTest
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            (string fileFormat, string folderPath) = HandlerUserInput.GetUserInputs(true);

            var handlers = HandlerUserList.GetUserHandlers();
            var tasks = handlers.Select(handler => handler.GetUsers()).ToList();

            await Task.WhenAll(tasks);

            var users = tasks.SelectMany(task => task.Result).ToList();

           
            Console.WriteLine($"Total users fetched: {users.Count}");

            await SaveUtil.SaveUsersAsync(users, folderPath, fileFormat);

            stopwatch.Stop();

            Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
