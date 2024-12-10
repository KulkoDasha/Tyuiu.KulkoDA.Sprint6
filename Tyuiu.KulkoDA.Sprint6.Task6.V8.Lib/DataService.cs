using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        
        public string CollectTextFromFile(string path)
        {
            string[] a = File.ReadAllLines(path);
            string str = "";
            StringBuilder sb = new StringBuilder(a.Length);
            str = sb.Append(a).ToString();
            
            return str;
        }
    }
}
