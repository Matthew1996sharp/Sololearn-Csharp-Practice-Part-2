using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    class Program
    {
        // В интеллектуальной телевикторине 5 участников дошли до последнего раунда,
        // и пришло время определить победителя и завершить игру
        // Данная программа определяет массив финалистов, использует индекс потребителя
        // в качестве вводных данных и создаёт объект FinalRound
        // завершите класс FinalRound - напишите необходимый код в конструкторе,
        // который использует массив и индекс потребителя в качестве примеров
        // и выведет соответствующее собщение с указанием победителя.
        // Затем создайте деструктор для завершения игры и вывода фразы "Game Over"

        static void Main(string[] args)
        {
            string[] finalists = 
                { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };
            int winner = Convert.ToInt32(Console.ReadLine());
            FinalRound = finalRound = new FinalRound(finalists, winner);
        }
    }
    
    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            Console.WriteLine("Winner is " + finalists[winner]);
        }
        ~FinalRound()
        {
            Console.WriteLine("Game Over");
        }
    }
}
