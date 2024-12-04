using Tyuiu.KulkoDA.Sprint6.Task0.V28.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            var res =ds.Calculate(x);
            Assert.AreEqual(169.89,res);
        }
    }
}