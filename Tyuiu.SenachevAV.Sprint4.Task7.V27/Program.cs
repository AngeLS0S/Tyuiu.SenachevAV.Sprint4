using Tyuiu.SenachevAV.Sprint4.Task7.V27.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4;
        int m = 3;
        int[,] mtrx = new int [n, m];

        String value = "583197256891";

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Сеначев А. В. | АСОиУБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #27                                                             *");
        Console.WriteLine("* Выполнил: Сеначев Андрей Вячеславович  | АСОиУБ-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"583197256891\".                     *");
        Console.WriteLine("* Преобразуйте ее в матрицу 4 на 3 и подсчитайте количество четных чисел. *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");

        int index = 0;
        Console.WriteLine("\nМассив");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.WriteLine($"{value[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.Calculate(n, m, value);
        Console.WriteLine("Количество чётных элементов = " + res);
        Console.ReadKey();

    }
}