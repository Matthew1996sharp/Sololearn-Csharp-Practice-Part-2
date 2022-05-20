using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._1
{
    // Вы создаете программу, которая может выводить значение перменной любого типа
    // Программа берет строку, целое число и число с плавающей точкой
    // в качестве вводных данных и выводит их в результат
    // Создайте универсальный метод Print для класса Printer,
    // чтобы данные вызовы функций выполнялись верно

    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubleNum = Convert.ToDouble(Console.ReadLine());

            Printer.Print<string>(ref text);
            Printer.Print<int>(ref intNum);
            Printer.Print<double>(ref doubleNum);

            Console.ReadKey();
        }
    }

    class Printer
    {
        public static void Print<T>(ref T a)
        {
            Console.WriteLine("Showing " + a);
        }
    }
}
