using Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutFileTask5V27.txt";
            var res = ds.LoadFromDataFile(path);
            double[] mass = { -17.0, 0, 12.0, -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77,-9, 13.83, 12.76, 8.86, 0, -1.49, -7 };
            CollectionAssert.AreEqual(mass, res);
        }
    }
}