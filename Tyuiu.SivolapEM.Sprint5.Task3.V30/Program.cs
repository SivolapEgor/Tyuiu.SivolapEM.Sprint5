using Tyuiu.SivolapEM.Sprint5.Task3.V30.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет значение выражения по формуле     *");
        Console.WriteLine("* при x = 3, результат сохранить в бинарный файл.                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" x = " + x);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}