using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    internal class Program
    {
        // Данная программа берет 2 числа в качестве вволдных данных,
        // проводит вычисления и выводит в результат их среднее
        // Завершите класс Avg, создав конструктор,
        // где 2 взятых параметра будут присвоены членам класса

        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);
            Console.WriteLine(avg.GetAvg());
            Console.ReadKey();
        }
    }

    class Avg
    {
        readonly double num1;
        readonly double num2;

        public Avg(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double GetAvg()
        {
            return (this.num1 + this.num2) / 2;
        }
    }
}
