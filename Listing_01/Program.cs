using System;
using System.Threading.Tasks;
/// <summary>
/// Hello Task
/// </summary>
namespace Listing_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Hello World!");
            });

            // wait for input before exiting
            Console.WriteLine("Main method complete. Press enter to finish.");
            Console.ReadLine();
        }
    }
}
