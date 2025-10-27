using Tyuiu.PisarevMA.Sprint3.Task3.V4.Lib;
namespace Tyuiu.PisarevMA.Sprint3.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            char item = 'j';
            string value = "plkjjdw cvjkl";
            string res = ds.DeleteCharInString(value, item);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}
