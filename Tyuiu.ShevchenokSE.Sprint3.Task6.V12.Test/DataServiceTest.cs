using Tyuiu.ShevchenokSE.Sprint3.Task6.V12.Lib;
namespace Tyuiu.ShevchenokSE.Sprint3.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 9;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 215;
            Assert.AreEqual(wait, res);
        }
    }
}