using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] a = new double[20]; 
            
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    double b = Convert.ToDouble(line);
                    for(int i = 0; i < a.Length; i++)
                    {
                        if(b%5!=0)
                        {
                            a[i] = b;
                        }
                    }
                }
            }
            return a;
        }
    }
}
