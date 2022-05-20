using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._5
{
    // Мы нанимаем в команду программистов. Кандидаитов всего 10, и нам нужно выбрать 3
    // В наборе hashSet данной программы есть 1- кандидатов.
    // Вам необходимо взять 3 имени в качестве вводных данных,
    // добавить их в новый набор HashSet нанятых и проверить,
    // указаны ли они в нашем наборе кандидатов
    // Если да, то программа должна вывести 'Starting hiring process".
    // В противном случае "Something went wrong"

    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            for (int i = 0; i < 3; i++)
            {
                string hire = Console.ReadLine();
                hiring.Add(hire);
            }

            if (hiring.IsSubsetOf(candidates)) Console.WriteLine("Starting hiring process");
            else Console.WriteLine("Something went wrong");
            Console.ReadKey();
        }
    }
}
