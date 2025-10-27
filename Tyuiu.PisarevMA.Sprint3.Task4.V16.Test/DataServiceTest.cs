using Tyuiu.PisarevMA.Sprint3.Task4.V16.Lib;
namespace Tyuiu.PisarevMA.Sprint3.Task4.V16.Test
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
            double res = ds.Calculate(startValue, stopValue);
            double wait = 2.757;
            Assert.AreEqual(wait, res);
        }
    }
}
