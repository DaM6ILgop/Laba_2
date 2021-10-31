using System;

class program 
{

    static void Main(string[] args)
        
    { flag:
        try
        {
            Console.WriteLine("введите число ");
            double value = double.Parse(Console.ReadLine());

            if (value >= 1 && value <= 100000)
            {
                value = Math.Pow(value, 1.0 / 3.0);

                if (value % 1 == 0)// проверка на остаток. если есть остаток, то ветка else
                {
                    Console.WriteLine("true");
                }
                else if (value % 1 != 0)
                {
                    Console.WriteLine("false");

                }
            }
            else
            {
                Console.WriteLine("капец");
            }
            goto flag;
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод");
            goto flag;
        }
    }
}
    


