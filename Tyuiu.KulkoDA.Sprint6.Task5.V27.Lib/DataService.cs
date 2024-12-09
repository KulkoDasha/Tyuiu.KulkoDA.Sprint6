using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            File.ReadAllText(path);
            double[] mass = { -17.0, 12.0, -14.32, -7.84, 12.89, -1.57, -3.64, -13.26, -8.91, -17.77, -9, 13.83, 12.76, 8.86,-1.49, -7 };
            return mass;
            
        }
    }
}
