using System;

namespace Test_12_PolesUP
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Введите число ISBN10 на проверку действительности. Пример ввода #-###-#####-X, где # - число от 1-9, а X - число от 1-9 и X(10)");
                string ISBN;
                do
                {
                    ISBN = Console.ReadLine();
                } while (ISBN.Length != 13);
                double Sum = 0;
                int j = 0;
                for (int i = 0; i < 13; i++)
                {
                    if (ISBN[i] == 'X')
                    {
                        Sum += 10;
                        j += 1;
                    }
                    else if (ISBN[i] == '-')
                    {
                    }
                    else if (ISBN[i] >= '0' && ISBN[i] <= '9')
                    {
                        Sum += Convert.ToDouble(Convert.ToString(ISBN[i])) * (10 - j);
                        j += 1;
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                if (Sum % 11 == 0)
                    Console.WriteLine(true);
                else
                    Console.WriteLine(false);
            }
        }
    }
}
