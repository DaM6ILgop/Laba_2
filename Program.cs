using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
          flag:
            int input;
            try
            {
                Console.WriteLine("Введите число от 1 до 100");
                input = int.Parse(Console.ReadLine());
                while (input < 1 || input > 100)
                {
                    Console.WriteLine("Вы вышли за границу диапазона.\nВведите число снова");
                    goto flag;
                }
                if (input % 10 == 1 & (input > 11 || input < 2))
                {
                    Console.WriteLine($"{input} год");
                    goto flag;
                }
                else if (input % 10 < 5 & input % 10 > 1)
                {
                    Console.WriteLine($"{input} года");
                    goto flag;
                }
                else
                {
                    Console.WriteLine($"{input} лет");
                    goto flag;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Введите число ");
                goto flag;
            }
        }  
    }
}
