namespace Milestone2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            Console.WriteLine("Adding Normal 2 + 2 integers");
            Console.WriteLine(calculator.Add(2, 2));

            Console.WriteLine("Adding Normal 3 + 3 + 3 integers");
            Console.WriteLine(calculator.Add(3,3,3));

            Console.WriteLine("Adding Normal 1.2 + 2.4 floats");
            Console.WriteLine(calculator.Add(1.2f,2.4f));

            Console.WriteLine("Normal Latest Result");
            Console.WriteLine(calculator.GetResult());

            IAdvancedCalculator advancedCalculator = new AdvancedCalculator();

            Console.WriteLine("Adding Advanced 2 + 2 integers");
            Console.WriteLine(advancedCalculator.Add(2,2));

            Console.WriteLine("Adding Advanced 3 + 3 + 3 integers");
            Console.WriteLine(advancedCalculator.Add(3, 3, 3));

            Console.WriteLine("Adding Advanced 1.2 + 2.4 floats");
            Console.WriteLine(advancedCalculator.Add(1.2f, 2.4f));

            Console.WriteLine("Power Advanced 2^3 ");
            Console.WriteLine(advancedCalculator.Power(2,3));

            Console.WriteLine("Advanced Latest Result in Macros");
            Console.WriteLine(advancedCalculator.GetResult);



        }
    }
}
