using System;

namespace Zadanie2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Вычисление числа Пи:");
            Console.WriteLine("Введите кол-во слагаемых");
            int Count = int.Parse(Console.ReadLine());
            double n = 3;
            double p = 1;           
            while (i < Count)
            {
                p = p - (1 / n) + (1 / (n + 2));
                n = n + 4;
                i++;
            }
            Console.WriteLine(p * 4);

        }
    } 
    
}