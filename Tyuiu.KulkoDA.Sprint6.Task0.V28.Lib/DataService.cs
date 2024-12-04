﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KulkoDA.Sprint6.Task0.V28.Lib
{
    public class DataService : ISprint6Task0V28
    {
        public double Calculate(int x)
        {
            double res = 6.1 * x * x * x + 0.23 * x * x + 1.04 * x;
            return res;
        }
    }
}
