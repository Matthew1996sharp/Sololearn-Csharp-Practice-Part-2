using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2
{
    internal class Program
    {
        // Данная программа берёт 5 чисел в качестве входных данных и сохраняет их в массив.
        // Завершите программу, которая проанализирует массив и выведет в результат сумму чётных чисел

        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int sumEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] % 2 == 0) sumEven += numbers[i];
            }

            Console.WriteLine(sumEven);
            Console.ReadKey();
        }
    }
}
