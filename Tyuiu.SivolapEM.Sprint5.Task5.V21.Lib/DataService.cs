using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            NumberFormatInfo info = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ","
            };
            string text = File.ReadAllText(path);
            string[] strings = text.Split(' ');

            double? maxEvenInt = null;

            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number))
                {
                    if (number % 1 == 0 && number % 2 == 0)
                    {
                        if (!maxEvenInt.HasValue || number > maxEvenInt.Value)
                        {
                            maxEvenInt = number;
                        }
                    }
                }
            }
            return GetFactorial((int)maxEvenInt.Value);
        }

        private double GetFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.", nameof(n));
            }
            if (n == 0)
            {
                return 1;
            }

            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
