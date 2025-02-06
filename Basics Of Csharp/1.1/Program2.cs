using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program2
    {
        public static void RunProgram()
        {
            Console.WriteLine("Enter a series of numbers separated by commas:");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(',');

            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = int.Parse(numberStrings[i].Trim());
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}
