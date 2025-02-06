using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program5
    {
        public static void RunProgram()
        {
            Console.WriteLine("Enter your date of birth (yyyy-MM-dd):");
            string input = Console.ReadLine();

            DateTime dateOfBirth;
            bool isValidDate = DateTime.TryParse(input, out dateOfBirth);

            if (!isValidDate)
            {
                Console.WriteLine("Invalid date format. Please enter the date in yyyy-MM-dd format.");
                return;
            }

            DateTime today = DateTime.Today;
            int years = today.Year - dateOfBirth.Year;
            int months = today.Month - dateOfBirth.Month;
            int days = today.Day - dateOfBirth.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(today.Year, today.Month - 1);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"You are {years} years, {months} months, and {days} days old.");
        }
    }
}
