using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShevchenokSE.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = 0;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + (Math.Pow(value, i) + 0.5) * Math.Cos(i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}