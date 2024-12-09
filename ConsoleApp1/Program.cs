using Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutFileTask5V27.txt";
            var res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}
