using Tyuiu.SenachevAV.Sprint4.Task6.V1.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Сеначев А. В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович  | АСОиУБ-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [Яблоко Банан Вишня Драгонфрут Бузина Инжир *");
        Console.WriteLine("* Виноград] используя класс Array подсчитайте количество элементов        *");
        Console.WriteLine("* длина которых больше 6.                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");

        var fruits = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < fruits.Length - 1; i++)
        {
            Console.WriteLine(fruits[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int nums = ds.Calculate(fruits);
        Console.WriteLine(nums);
        Console.ReadKey();
    }
}