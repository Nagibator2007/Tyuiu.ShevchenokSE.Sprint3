using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShevchenokSE.Sprint3.Task6.V12.Lib
{
    public sealed class DataService : ISprint3Task6V12
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }
    }
}