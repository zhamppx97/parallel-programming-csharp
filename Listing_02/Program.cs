using System;
using System.Threading.Tasks;
/// <summary>
/// Four ways to create basic tasks
/// </summary>
namespace Listing_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // use an action delegate and a named method
            Task task1 = new Task(new Action(PrintMessage));
            // use a anonymous delegate
            Task task2 = new Task(delegate
            {
                PrintMessage();
            });
            // use a lambda expression and a named method
            Task task3 = new Task(() => PrintMessage());
            // use a lambda expression and an anonymous method
            Task task4 = new Task(() =>
            {
                PrintMessage();
            });

            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
