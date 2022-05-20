using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._3
{
    internal class Program
    {
        // Данная программа берет число N в качестве размера массива,
        // а потом N количество чисел
        // Завершите программу таким образом, чтобы она отсортировала
        // и вывела в результат каждый элемент массива с новой строки

        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numbers);

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
