using Tyuiu.SenachevAV.Sprint4.Task6.V1.Lib;

namespace Tyuiu.SenachevAV.Sprint4.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var fruits = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(fruits);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}