using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._3
{
    // Туроператор предлагает выходные туры в Англию, испанию, Италию, Португалию и Францию
    // Данная программа определяет массив с указанными вариантами и принимает число N в качестве вводных данных
    // Напишите программу для вывода тура с индексом N.
    // Если число не входит в определенный диапазон,
    // то программа должна вывести в резульат фразу "Wrong number"
    // также независимо от результата программа должна выводить в конце фразу "Goodbye"

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(tours[choice]);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Wrong number");
            }

            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
