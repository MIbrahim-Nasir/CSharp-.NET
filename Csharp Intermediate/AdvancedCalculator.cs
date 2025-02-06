namespace Milestone2
{
    public class AdvancedCalculator : Calculator, IAdvancedCalculator
    {
        public int Power(int baseValue, int exponent)
        {
            Result = Math.Pow(baseValue, exponent);
            return (int)Result;
        }

        public override double GetResult()
        {
            return Result * 1_000_000;
        }
    }
}
