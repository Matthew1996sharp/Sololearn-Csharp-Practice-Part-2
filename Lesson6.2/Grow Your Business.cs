using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    internal class Program
    {
        // В нашей компании 2 отдела, но она развивается и нужно создавать новые.
        // Данная программа берет количество департаментов, которое нужно создать
        // в качестве вводных данных, затем использует их названия и создает объекты Department,
        // передавая их названия в конструктор в качестве аргументов
        // Завершите класс Department таким образом, чтобы в нем был 1 статический член
        // depCount с начальным значением 2, равным количеству отделов и конструктор,
        // которрый посчитает и выведет соответствующее сообщение

        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + 
                (Convert.ToInt32(Department.depCount) + Convert.ToInt32(numOfDeps)));
            Console.ReadKey();
        }
    }

    class Department
    {
        public string depName;
        public static int depCount = 2;
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
        }
    }
}
