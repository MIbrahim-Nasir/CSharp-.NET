
namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose a number between 1 and 6 (or enter 0 to exit):");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Program1.RunProgram();
                        break;
                    case 2:
                        Program2.RunProgram();
                        break;
                    case 3:
                        Program3.RunProgram();
                        break;
                    case 4:
                        Program4.RunProgram();
                        break;
                    case 5:
                        Program5.RunProgram();
                        break;
                    case 6:
                        Program6.RunProgram();
                        break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 6, or enter 0 to exit.");
                        break;
                }
            }
        }
    }
}

//static void Main(string[] args)
//{
//    int sum = 0;
//    while (true)
//    {
//        Console.WriteLine("Enter a number or type 'ok' to exit:");
//        string input = Console.ReadLine();

//        if (input.ToLower() == "ok")
//        {
//            break;
//        }

//        try
//        {
//            int number = int.Parse(input);
//            sum += number;
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
//        }
//    }

//    Console.WriteLine($"The sum of all entered numbers is: {sum}");
//}
