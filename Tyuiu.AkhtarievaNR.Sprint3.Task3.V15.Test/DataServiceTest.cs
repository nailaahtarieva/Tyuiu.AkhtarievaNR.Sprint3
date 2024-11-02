using Tyuiu.AkhtarievaNR.Sprint3.Task3.V15.Lib;

namespace Tyuiu.AkhtarievaNR.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "lrmmse mg sermmmrt";
            char chr = 'a';

            double res = ds.GetMinCharCount(value,chr);
            int wait = 1;

            Assert.AreEqual(wait, res);
        }
    }
}