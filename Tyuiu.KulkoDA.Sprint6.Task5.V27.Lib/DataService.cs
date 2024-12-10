﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] mass = new double[len];
            int a = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    mass[a] = Convert.ToDouble(line);
                    a++;
                }

            }
            mass = mass.Where(i=>i%5!=0).ToArray();
            return mass;
        }
    }
}
