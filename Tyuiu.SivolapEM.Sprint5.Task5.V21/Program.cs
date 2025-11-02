using Tyuiu.SivolapEM.Sprint5.Task5.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Сиволап Е.М. | ИППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет наибольший факториал чисел        *");
        Console.WriteLine("* в файле.                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask5V3.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);
    }
}