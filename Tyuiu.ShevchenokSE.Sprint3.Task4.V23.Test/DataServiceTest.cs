using Tyuiu.ShevchenokSE.Sprint3.Task4.V23.Lib;
namespace Tyuiu.ShevchenokSE.Sprint3.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double wait = 15.104;
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}