using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3
{
    internal class Program
    {
        // Дан многомерный массив. Завершите программу для вывода данного массива в форме таблицы

        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int j = 0; j < num.GetLength(0); j++)
            {
                for (int i = 0; i < num.GetLength(1); i++)
                {
                    Console.Write(num[j, i]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
