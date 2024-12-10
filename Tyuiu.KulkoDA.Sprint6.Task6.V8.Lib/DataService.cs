using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public int len;
        public string CollectTextFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            string resStr = "";
            string str = "z";
            string[] a = new string[len];
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        a = line.Split(' ').ToArray();
                    }
                }
                for(int i = 0; i < a.Length; i++)
                {
                    if(a.Contains(str))
                    {
                        resStr = resStr+" " +a[i];
                    }
                } 
                
            }
            return resStr ;
        }
    }
}
