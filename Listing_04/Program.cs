using System;
using System.Threading.Tasks;
/// <summary>
/// Creating several Tasks Using Task State
/// </summary>
namespace Listing_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] messages = { "First task", "Second task", "Third task", "Fourth task" };
            foreach (string msg in messages)
            {
                Task myTask = new Task(obj => PrintMessage((string)obj), msg);
                myTask.Start();
            }

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine("Message: {0}", message);
        }
    }
}
