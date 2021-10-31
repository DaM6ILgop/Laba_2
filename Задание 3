using System;

namespace Zadanie3Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программно найдем первое четырехзначное число в ряде чисел Фибоначчи:");
            double f0 = 0;
            double f1 = 1;
            while (f1 < 1000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine($"Первым четырехзначным числом в ряде числел Фибоначчи является {f1}");
            Console.WriteLine("Теперь вычислим кол-во четырехзначных чисел в ряде Фибоначчи:");
            int count = 0;
            while (f1 < 10000)
            {
                double f = f0 + f1;
                f0 = f1;
                f1 = f;
                count++;
            }
            Console.WriteLine($"Кол-во четырехзначных чисел Фибоначчи = {count}");
        }
    }
}
