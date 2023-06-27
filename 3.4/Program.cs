using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount, temp;
            int minNumber = int.MaxValue;
            Console.WriteLine("Введите количество чисел");
            numbersCount = EnterNumber();
            for(int i = 0; i < numbersCount; i++)
            {
                Console.WriteLine($"Введите {i + 1} число");
                temp = EnterNumber();
                minNumber = temp < minNumber ? temp : minNumber;
            }
            Console.WriteLine($"Минимальное число - {minNumber}");
            Console.ReadKey();
        }

        private static int EnterNumber()
        {
            int number;
            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    return number;
                }
                catch
                {
                    Console.WriteLine("Введите число");
                }
            }
            return int.MaxValue;
        }
    }
}
