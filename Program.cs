using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Комбо натуральных чисел ");          
            flag:
            try
            {
                Console.WriteLine("Введите число N");
                double numberN = double.Parse(Console.ReadLine());
                double sum;
                int f = 0;
                for (x = 0; x <= numberN; x++)
                {
                    for (y = 0; y <= numberN; y++)
                    {
                        for (z = 0; z <= numberN; z++)
                        {
                            sum = Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3);
                            if (sum == numberN)
                            {
                                Console.WriteLine($"{x}^3 + {y}^3 + {z}^3 = {numberN}");
                                f++;                               
                            }                            
                        }
                    }
                } 
                if (f == 0)
                {
                    Console.WriteLine("No such combinations!");
                    goto flag;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число. Попробуйте снова");
                /*(╯°□°）╯︵ ┻━┻*/
                goto flag; 
            }
        }
    }
}
