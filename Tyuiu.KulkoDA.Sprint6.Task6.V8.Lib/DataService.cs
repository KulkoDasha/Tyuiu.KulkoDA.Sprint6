using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            string str = "z";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
