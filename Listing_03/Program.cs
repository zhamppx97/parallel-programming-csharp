using System;
using System.Threading.Tasks;
/// <summary>
/// Adding task state
/// </summary>
namespace Listing_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // use an action delegate and a named method
            Task task1 = new Task(new Action<object>(PrintMessage), "First task");
            // use a anonymous delegate
            Task task2 = new Task(delegate (object obj) { PrintMessage(obj); }, "Second task");
            // use a lambda expression and a named method
            // note that parameters to a lambda don't need
            // to be quoted if there is only one parameter
            Task task3 = new Task((obj) => PrintMessage(obj), "Third task");
            // use a lambda expression and an anonymous method
            Task task4 = new Task((obj) => { PrintMessage(obj); }, "Fourth task");

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }

        static void PrintMessage(object message)
        {
            Console.WriteLine("Message: {0}", message);
        }
    }
}
