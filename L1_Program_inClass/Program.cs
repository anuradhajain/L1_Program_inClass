using System;

namespace L1_Program_inClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number:");
                string input = Console.ReadLine();

                int number = int.Parse(input);

                int modules = number % 2;

                if (modules == 0)
                {
                    Console.WriteLine("Its an even number:");
                } // end of if

                else
                {
                    Console.WriteLine("Its an odd number");
                } // end of else

                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of try

            catch
            {
                Console.WriteLine("There is some error. Please enter a valid integer next time");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of catch
        }
    }
}
