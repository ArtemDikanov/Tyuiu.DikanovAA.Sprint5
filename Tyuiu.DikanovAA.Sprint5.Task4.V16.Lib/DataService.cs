﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DikanovAA.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', '.');
            double x = Convert.ToDouble(strX);
            double res = Math.Round((Math.Cos(x) + Math.Pow(x, 2) - ((2 * x) / 1.2)), 3);
            return res;
        }
    }
}
