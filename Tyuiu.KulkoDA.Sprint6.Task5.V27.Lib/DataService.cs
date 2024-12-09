using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            double[] a; 
            
            using(StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    double[] b = line.Split(' ').Select(Double.Parse).ToArray();
                    for(int i =0; i < b.Length; i++)
                    {
                        if (b[i]%5!=0)
                        {
                            a[i] = b[i];
                        }
                    }
                }
            }
            return a;
        }
    }
}
