using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program3
    {
        public static void RunProgram()
        {
            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated numbers:");
                string input = Console.ReadLine();

                string[] numberStrings = input.Split(',');

                if (numberStrings.Length < 5)
                {
                    Console.WriteLine("Invalid List. Please try again.");
                    continue;
                }

                int[] numbers = new int[numberStrings.Length];
                try
                {
                    for (int i = 0; i < numberStrings.Length; i++)
                    {
                        numbers[i] = int.Parse(numberStrings[i].Trim());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid List. Please enter valid numbers.");
                    continue;
                }

                int smallest = int.MaxValue;
                int secondSmallest = int.MaxValue;
                int thirdSmallest = int.MaxValue;

                foreach (int number in numbers)
                {
                    if (number < smallest)
                    {
                        thirdSmallest = secondSmallest;
                        secondSmallest = smallest;
                        smallest = number;
                    }
                    else if (number < secondSmallest)
                    {
                        thirdSmallest = secondSmallest;
                        secondSmallest = number;
                    }
                    else if (number < thirdSmallest)
                    {
                        thirdSmallest = number;
                    }
                }

                Console.WriteLine("The three smallest numbers are:");
                Console.WriteLine(smallest);
                Console.WriteLine(secondSmallest);
                Console.WriteLine(thirdSmallest);
                break;
            }
        }
    }
}
