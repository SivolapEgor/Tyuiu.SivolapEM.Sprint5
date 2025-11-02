using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task2.V6.Lib
{
    public class DataService : ISprint5Task2V6
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.csv" });
            FileInfo file = new FileInfo(path);

            if (file.Exists)
            {
                File.Delete(path);
            }

            if (matrix == null)
            {
                throw new ArgumentNullException(nameof(matrix), "Матрица не может быть null.");
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] resultMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] > 0 ? 1 : 0;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(resultMatrix[i, j]);
                    if (j < cols - 1)
                    {
                        sb.Append(";");
                    }
                }
                sb.AppendLine();
            }

            File.WriteAllText(path, sb.ToString());

            return path;
        }
    }
}
