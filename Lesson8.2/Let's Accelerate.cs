using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._2
{
    // В гоночной видеоигре 3 уровня сожности: легкий, средний и сложный
    // На каждом уровне игроку дается время для прохождения трека: чем сложнее уровень тем меньше времени
    // Данная программа определяет класс Player и перечисление Difficulty,
    // а также создает 3 объекта Player с разными вариантами сложности в качестве параметра
    // завершите конструктор Player, который использует перечисление в качестве параметра
    // для проверки времени на каждом уровне и выводит результат в соответсвующее сообщение

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);

            Console.ReadKey();
        }
    }

    class Player
    {
        public Player(Difficulty x)
        {
            switch (x)
            {
                case Difficulty.Easy:
                    Console.WriteLine("You have 3 minutes 45 seconds");
                    break;
                case Difficulty.Medium:
                    Console.WriteLine("You have 3 minutes 20 seconds");
                    break;
                case Difficulty.Hard:
                    Console.WriteLine("You have 3 minutes");
                    break;
            }
        }
    }

    enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}
