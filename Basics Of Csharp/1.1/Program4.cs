using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program4
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

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine("The numbers in descending order are:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
