using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._4
{
    internal class Program
    {
        // Отборочные соревнования для участия в Олимпиаде длятся 3 дня,
        // и по итогам каждого отборочного дня определяется один победитель.
        // данный массив массивов представляет собой список всех участников,
        // разделенный по дням (внутри основного массива находятся 3 массива,
        // каждый из которых представляет собой список участников,
        // которые участвовали в соревнованиях в соответствующий день)

        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());

            string[][] olympiad = new string[][]
            {
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana"}
            };

            Console.WriteLine(olympiad[0][day1Winner - 1]);
            Console.WriteLine(olympiad[1][day2Winner - 1]);
            Console.WriteLine(olympiad[2][day3Winner - 1]);
            Console.ReadKey();
        }
    }
}
