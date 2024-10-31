using Tyuiu.AkhtarievaNR.Sprint3.Task2.V24.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 55217.446;

            Assert.AreEqual(wait, res);
        }
    }
}