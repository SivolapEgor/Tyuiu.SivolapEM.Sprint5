using Tyuiu.SivolapEM.Sprint5.Task1.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int startvalue = -5;
        int stopvalue = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Сиволап Е.М. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Сиволап Егор Максимович | ИИПб-25-1     r                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая производит табулирование функции на         *");
        Console.WriteLine("* заданном диапазоне [-5;5] с шагом 1 и сохраняет результат в текстовый   *");
        Console.WriteLine("* файл.                                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("startValue = " + startvalue);
        Console.WriteLine("stopValue = " + stopvalue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startvalue, stopvalue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
    }
}