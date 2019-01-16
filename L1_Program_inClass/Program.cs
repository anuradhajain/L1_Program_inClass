using System;

namespace L1_Program_inClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Exercise 1

                // Finding the area of a triangle using heron's formula
                   
                // Taking 3 numbers as user input for the sides of a traingle
                Console.WriteLine("Please enter 3 numbers as the sides of a triangle");
                string input_a = Console.ReadLine();
                string input_b = Console.ReadLine();
                string input_c = Console.ReadLine();

                // Parsing the 3 input numbers to integers
                double a = double.Parse(input_a);
                double b = double.Parse(input_b);
                double c = double.Parse(input_c);

                // Calculating the area of the triangle where a,b and c are the 3 sides
                double s = (a + b + c) / 2;
                double Area = Math.Sqrt(s *(s - a) * (s - b) * (s - c));

                // Displaying the area to teh console
                Console.WriteLine("The area of the triangle is: " + Area);

                //Execise 2

                // taking a number as user input and identifying it as even or odd
                Console.WriteLine("\nPlease enter a number to find if it is odd or even:");
                string input = Console.ReadLine();

                int number = int.Parse(input); // parsing the input to an integer

                int modulus = number % 2; // storing the remainder of number divided by 2 in a variable modulus

                // if the remainder is 0, it means the number is completely divisible by 2. hence an even number. else an odd number
                if (modulus == 0)
                {
                    Console.WriteLine("Its an even number");
                } // end of if

                else
                {
                    Console.WriteLine("Its an odd number");
                } // end of else

                // Exercise 3

                // Taking 3 numbers as user input and finding the maximum of those numbers
                Console.WriteLine("\nPlease enter 3 numbers to find their maximum");
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();

                // Parsing the 3 input numbers to integers
                int number1 = int.Parse(input1);
                int number2 = int.Parse(input2);
                int number3 = int.Parse(input3);

                // Finding the maximum of 3 numbers
                int var_max = Math.Max(number1, number2);
                int max_num = Math.Max(var_max, number3);

                // Displaying the maximum of 3 numbers on the console
                Console.WriteLine("The maximum of " + number1 + ", " + number2 + " and " + number3 + " is: " + max_num);

                // taking user input for exit statement
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey(true);
            } // end of try

            // if any error occurs in try block, the program comes to catch block and displays error message. otherwise this part is not executed
            catch
            {
                Console.WriteLine("\nThere is some error. Please enter a valid integer next time");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(true);
            } // end of catch

        } // end of main
    } // end of class
} // end of namespace
