using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShevchenokSE.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double multSeries = 0;
            while (startValue <= stopValue)
            {
                multSeries = multSeries + (Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}