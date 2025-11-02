using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double y; string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (4*x-0.5 != 0)
                {
                    y = 3*Math.Cos(x) / (4*x-0.5) + Math.Sin(x) - 5*x - 2;
                    strY = Convert.ToString(y);
                }
                else
                {
                    y = 0; strY = "0";
                }
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
