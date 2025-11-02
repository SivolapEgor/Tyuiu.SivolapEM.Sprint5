using Tyuiu.SivolapEM.Sprint5.Task7.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая заменит все строчные русские буквы на       *"); 
        Console.WriteLine("* заглавные.                                                              *");
        Console.WriteLine("* Полученный результат сохранит в файл OutPutDataFileTask7V12.txt.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";
        string pathSaveFile = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V12.txt" });
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSaveFile);
    }
}