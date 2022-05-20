using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._6
{
    // Каждый игрок должен пройти 2 раунда и получить очки за каждый
    // Данная программа создает два объекта Score,
    // где хранятся очки за каждый балл (они передаются в конструктор)
    // Перегрузите оператор + для класса Score,
    // чтобы вычислить счёт команды в каждом раунде

    internal class Program
    {
        static void Main(string[] args)
        {
            Score player1 = new Score(2, 3);
            Score player2 = new Score(4, 2);

            Score finalScores = player1 + player2;

            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);

            Console.ReadKey();
        }
    }

    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }

        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }

        public static Score operator+(Score x, Score y)
        {
            int a = x.round1Score + y.round1Score;
            int b = x.round2Score + y.round2Score;

            Score result = new Score(a, b);
            return result;
        }
    }
}
