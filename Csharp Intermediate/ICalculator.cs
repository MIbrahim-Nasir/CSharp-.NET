namespace Milestone2
{
    public interface ICalculator
    {
        int Add(int x,  int y);
        int Add(int x, int y, int z);
        float Add(float x, float y);

        double GetResult();
    }
}
