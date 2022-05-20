using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._4
{
    // Напишите программу, которая возьмет 3 числа
    // в качестве вводных данных и сохранит их в Queue
    // также добавьте код для вывода отсортированной
    // последовательности элементов в очереди через пробел

    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < 3; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                queue.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            int[] arr = queue.ToArray();
            Array.Sort(arr);

            Console.Write("Sorted: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
