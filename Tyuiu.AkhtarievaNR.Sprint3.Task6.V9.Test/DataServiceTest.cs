using Tyuiu.AkhtarievaNR.Sprint3.Task6.V9.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 19;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 53;

            Assert.AreEqual(wait, res);
        }
    }
}