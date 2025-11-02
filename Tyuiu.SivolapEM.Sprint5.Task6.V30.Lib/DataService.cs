using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int count = words.Count(word => word.Length == 8);

            return count;
        }
    }
}
