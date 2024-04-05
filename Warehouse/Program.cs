using System;

namespace Warehouse
{
    class Program
    {
        const string FILE_NAME = "c:\\WarehouseFiles\\ImportFile.xlsx";

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in warehouse app.");
            Console.WriteLine("Please make your selection.");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Check item");
            Console.WriteLine("Press 1, 2 or 3.");

            string choice = Console.ReadLine();

            Console.WriteLine($"Your choice is: {choice}");

            int chosenOption = 0;

            Int32.TryParse(choice, out chosenOption);

            Console.WriteLine("Please chose another option.");

            choice = Console.ReadLine();

            Int32.TryParse(choice, out chosenOption);

        }
    }

}
