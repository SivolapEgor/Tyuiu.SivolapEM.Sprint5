using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task4.V4.Lib
{
    public class DataService : ISprint5Task4V4
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, info);
            double res = 0.25 * x / Math.Cos(x);
            return Math.Round(res, 3);
        }
    }
}
