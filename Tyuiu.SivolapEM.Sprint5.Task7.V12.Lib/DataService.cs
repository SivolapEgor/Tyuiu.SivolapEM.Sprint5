using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SivolapEM.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V12.txt" });
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            if (fileInfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            string processedContent = Regex.Replace(content, "[а-яё]", m => m.Value.ToUpper());

            File.WriteAllText(pathSaveFile, processedContent);
            return pathSaveFile;
        }
    }
}
