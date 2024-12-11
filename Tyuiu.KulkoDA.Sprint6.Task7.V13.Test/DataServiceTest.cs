using Tyuiu.KulkoDA.Sprint6.Task7.V13.Lib;
namespace Tyuiu.KulkoDA.Sprint6.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask7V13.csv";
            int[,] wait = { { 1,1,1},{2,2,2 } };
            var res = ds.GetMatrix(path);
           CollectionAssert.AreEqual(wait, res );
            
        }
    }
}