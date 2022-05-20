using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._4
{
    // В игре-стратегии атаковать могут все единицы. Стандартная единица атакует мечом.
    // Но есть два типа единиц - мушкетеры и маги. которые атакуют по-другому
    // Программа заявляет класс Unit, у которого есть метод Attack(). Он выводит фразу "Using sword!"
    // Унаследуйте классы Musketeer и Magician из класса Unit и переопределите их методы Attack()
    // для вывода соответствующих сообщений при выполнении атаки

    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit.Attack();
            musketeer.Attack();
            magician.Attack();

            Console.ReadKey();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }

    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }
    }

    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }
    }
}
