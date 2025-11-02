using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double numerator = Math.Pow(x, 3) - 1;
            double denominator = 4 * Math.Pow(x, 2);
            double z = numerator / denominator;
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
