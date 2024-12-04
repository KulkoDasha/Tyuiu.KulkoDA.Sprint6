using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = stopValue - startValue+1;
            mass = new double[len];
            double y;
            int count = 0;
            for(int i = startValue; i <= stopValue; i++)
            {
                y = (5 * i + 2.5) / (Math.Sin(i) - 2.0) + 2;
                mass[count] = Math.Round(y,2);
                count++;
                
            }
            return mass;
        }
    }
}
