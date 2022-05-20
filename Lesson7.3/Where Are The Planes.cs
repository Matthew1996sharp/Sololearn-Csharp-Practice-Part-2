using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    // Вы работаете администратором аэропорта и отвечаете за назначение статусов полетов
    // Сначала программа отображала только статусы "Registration" и "Closed"
    // но нам нужно, чтобы в статусе указывалось больше информации
    // Унаследуйте класс WayStatus из класса Flight и завершите:
    // 1. конструктор для вывода "On the way"
    // 2. деструктор для вывода "Landed"

    internal class Program
    {
        static void Main(string[] args)
        {
            WayStatus status = new WayStatus();
            Console.ReadKey();
        }
    }

    class Flight
    {
        public Flight()
        {
            Console.WriteLine("Registration");
        }
        ~Flight()
        {
            Console.WriteLine("Closed");
        }
    }

    class WayStatus : Flight
    {
        public WayStatus()
        {
            Console.WriteLine("On the way");
        }
        ~WayStatus()
        {
            Console.WriteLine("Landed");
        }
    }
}
