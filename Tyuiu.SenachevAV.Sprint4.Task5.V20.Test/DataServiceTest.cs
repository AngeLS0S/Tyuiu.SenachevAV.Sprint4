using Tyuiu.SenachevAV.Sprint4.Task5.V20.Lib;

namespace Tyuiu.SenachevAV.Sprint4.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { -6, -1, 0, -2, -7, },
                                         { -3, -4, -1, -3, 3, },
                                         { -2, -7, -3, -2, -3, },
                                         { 1, -1, 2, -1, -5, },
                                         { 1, -3, -7, 3, 2, } };
            int res = ds.Calculate(mas);
            int wait = 12;
            Assert.AreEqual(wait,res);
        }
    }
}