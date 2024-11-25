using Tyuiu.SenachevAV.Sprint4.Task7.V27.Lib;

namespace Tyuiu.SenachevAV.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 4;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string value = "583197256891";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, value);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}