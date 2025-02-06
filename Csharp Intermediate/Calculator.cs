namespace Milestone2
{
    public class Calculator : ICalculator
    {
        protected double Result;
        public int Add(int x, int y)
        {
            Result = x + y;
            return (int)Result;
            
        }

        public int Add(int x, int y, int z)
        {
            Result = x + y + z;
            return (int)Result;
        }

        public float Add(float x, float y)
        {
            Result = x + y;
            return (float)Result;
        }

        public virtual double GetResult()
        {
            return Result;
        }
    }
}
