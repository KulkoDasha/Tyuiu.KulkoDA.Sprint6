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
            int[,] wait = { {-7 ,4,-14, 5 ,-20 ,-15 ,8 ,  6 ,  -9 , -2 },
                            { 8 ,-18,16 ,-19,16 ,-12,14 ,-7 ,-2 ,-4 },
                            { -6 ,-2 ,-15,13 ,-19,4,-13,6,-1 ,-13 },
                            { -2, -1 ,-18,5,-8,-11,7,9,3,-17 },
                            {-9 ,18,6,-3,20,-18,-10,-5 ,-12,11 },
                            { 13 ,10 ,-13,-1 ,-6 ,-15,-16,-20,16 ,6 },
                            { -20,-17,7 , -16,14 ,13 ,-6 ,13, 12, 17 },
                            { 2   -20 13  4   -20 -15 20  4   -17 15 },
                            { 13  3   -14 -3  19  4   19  14  12  5 },
                            {-5  9   3   8   8   -13 4   8   4   -17 } };

            var res = ds.GetMatrix(path);
           CollectionAssert.AreEqual(wait, res );
            
        }
    }
}