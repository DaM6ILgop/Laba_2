using System;

namespace Личное_1
{
    class Program
    {
        static void Main(string[] args)
        {   flag:
            try
            {
                point:
                Console.WriteLine("Введите координаты числа (А)\n===============================\n 2 координаты: ");

                double inputA_x = double.Parse(Console.ReadLine());
                double inputA_y = double.Parse(Console.ReadLine());
                if ((inputA_x == 0) && (inputA_y == 0))
                {
                    Console.WriteLine("Zero Cord");
                    goto point;
                }
               
                if ((inputA_x > 0) && (inputA_y > 0))
                {
                    Console.WriteLine("1-я Четверть ");
                }
                else if ((inputA_x < 0) && (inputA_y > 0))
                {
                    Console.WriteLine("2-я четверть");
                }
                else if ((inputA_x < 0) && (inputA_y < 0))
                {
                    Console.WriteLine("3-я четверть");
                }
                else if ((inputA_x > 0) && (inputA_y < 0))
                {
                    Console.WriteLine("4-я четверть");
                }

                Console.WriteLine("Введите координаты числа (B)\n===============================\n 2 координаты: ");

                double inputB_x = double.Parse(Console.ReadLine());
                double inputB_y = double.Parse(Console.ReadLine());
                if ((inputA_x > 0) && (inputA_y > 0))
                {
                    Console.WriteLine("1-я Четверть ");
                }
                else if ((inputB_x < 0) && (inputB_y > 0))
                {
                    Console.WriteLine("2-я четверть");
                }
                else if ((inputB_x < 0) && (inputB_y < 0))
                {
                    Console.WriteLine("3-я четверть");
                }
                else if ((inputB_x > 0) && (inputB_y < 0))
                {
                    Console.WriteLine("4-я четверть");
                }


                //Тело логики 
                if ((inputA_x > 0) && (inputA_y > 0) == ((inputB_x > 0) && (inputB_y > 0)))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");                    
                }
                
                if ((inputA_x < 0) && (inputA_y > 0) == ((inputB_x < 0) && (inputB_y > 0)))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                if ((inputA_x < 0) && (inputA_y < 0) == ((inputB_x < 0) && (inputB_y < 0)))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                if ((inputA_x > 0) && (inputA_y < 0) == ((inputB_x > 0) && (inputB_y < 0)))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный синтаксис");
                goto flag;
            }
            goto flag;
        } 
    }
}
