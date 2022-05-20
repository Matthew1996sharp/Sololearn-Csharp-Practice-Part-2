using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._1
{
    internal class Program
    {
        // на игровой машине установлено 5 игр. Напишите программу,
        // которая использует в качестве входных данных число N
        // и выведет в результат соответствующую игру с индексом N из массива.
        // Если пользователь вводит недействительное число (из диапазона массива),
        // то программа должна вывести в результат "Invalid number"

        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < games.Length) Console.WriteLine(games[N]);
            else Console.WriteLine("Invalid number");
            Console.ReadKey();
        }
    }
}
