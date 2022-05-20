using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._6
{
    internal class Program
    {
        // Мы создаём систему авторизации. Пароль не должен содержать этих символов
        // Напишите программу, которая использует пароль в качестве вводных данных
        // и выведет в результат "Invalid", если в нём содержится любой из запрещённых символов
        // Если требование удовлетворено, программа не должна выводить ничего

        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '&', '(', ')', '*', ',', '+', '-' };
            bool flag = true;

            foreach (char symbol in password)
            {
                for (int i = 0; i < notAllowedSymbols.Length; i++)
                {
                    if (symbol == notAllowedSymbols[i]) flag = false;
                }
            }

            if (flag == false) Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}
