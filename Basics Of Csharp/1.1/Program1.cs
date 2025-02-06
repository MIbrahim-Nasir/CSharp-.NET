using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program1
    {
        public static void RunProgram()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to exit:");
                string input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }

                try
                {
                    int number = int.Parse(input);
                    sum += number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
                }
            }

            Console.WriteLine($"The sum of all entered numbers is: {sum}");
        }
        
    }
}


