using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._5
{
    internal class Program
    {
        // Напишите программу, которая в качестве вводных данных использует 5 чисел,
        // затем произведёт вычисления и выведет результат сумму
        // минимального и максимального значений

        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(numbers.Min() + numbers.Max());
            Console.ReadKey();
        }
    }
}
