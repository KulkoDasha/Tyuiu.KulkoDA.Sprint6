using Tyuiu.KulkoDA.Sprint6.Task1.V25.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = -5;
            int z = 5;
            double[] d = {23.61,16.08,7.84,4.58,2.88,0.75,-4.47,-9.46,-7.41,-6.16,0};
            var res =ds.GetMassFunction(a,z);
            CollectionAssert.AreEqual(res, d);
        }
    }
}