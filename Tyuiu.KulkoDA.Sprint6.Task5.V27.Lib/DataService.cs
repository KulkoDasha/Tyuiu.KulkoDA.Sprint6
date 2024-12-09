using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] a = new double[20]; 
            double res = 0;
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    for(int i = 0; i < a.Length; i++)
                    {
                        a[i] = Convert.ToDouble(line);
                        
                    }
                }
            }
            return a;
        }
    }
}
