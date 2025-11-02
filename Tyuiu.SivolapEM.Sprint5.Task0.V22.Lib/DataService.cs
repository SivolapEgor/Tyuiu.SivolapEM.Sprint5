using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutputFileTask0.txt" });
            double y = Math.Pow(1 - x, 2) / (-3 * x);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
