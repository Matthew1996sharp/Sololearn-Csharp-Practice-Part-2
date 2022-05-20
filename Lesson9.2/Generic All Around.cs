using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9._2
{
    // Класс Enum создает трехразмерный массив целых чисел, определяет методы Add() и Show()
    // для сохранения элементов в массив и отображает их через пробел
    // Измените класс, чтобы сделать его обобщенным для выполнения тех же действий со строкой

    internal class Program
    {
        static void Main(string[] args)
        {
            Element<string> element1 = new Element<string>();
            element1.Add("John", "Tamara", "David");
            element1.Show();

            Console.WriteLine();

            Element<int> element2 = new Element<int>();
            element2.Add(5, 14, 13);
            element2.Show();

            Console.ReadKey();
        }
    }

    class Element<T>
    {
        public T[] elements = new T[3];

        public void Add(T element1, T element2, T element3)
        {
            elements[0] = element1;
            elements[1] = element2;
            elements[2] = element3;
        }

        public void Show()
        {
            foreach(T item in elements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
