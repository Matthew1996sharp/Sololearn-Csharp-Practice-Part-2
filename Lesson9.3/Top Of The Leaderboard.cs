using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._3
{
    // Вам необходимо написать программу для игры, которая будет сортировать результаты игроков
    // Данная программа берет в качестве вводного число N,
    // которое указывает на количество игроков и определяет список результатов
    // завершите программу. которая использует N количество чисел в качестве вводных данных,
    // сохранит их в списке результатов, отсортирует и выведет в результат через пробел

    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());
            List<int> scores = new List<int>();

            for (int i = 0; i < numOfPlayers; i++)
            {
                int score = Convert.ToInt32((Console.ReadLine()));
                scores.Add(score);
            }

            scores.Sort();

            foreach (int item in scores)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}
