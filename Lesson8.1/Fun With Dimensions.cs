using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8._1
{
    // Кубоид - трехмерная фигура, грани которой имеют длин, ширину и высоту
    // Данная программа принимает эти размеры в качестве вводных данных,
    // определяет структуру Cuboid и создает его объект
    // Завершите программу. создав конструктор,
    // который в качестве параметров использует длину, ширину и высоту
    // и присваивает их соответствующим членам структуры
    // Также завершите методы Volume() и Perimeter() внутри структуры,
    // чтобы вычислить и вывести на экран объем и периметр

    internal class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());

            Console.ReadKey();
        }
    }

    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        public Cuboid(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int Volume()
        {
            return length * width * height;
        }

        public int Perimeter()
        {
            return (length + width + height) * 4;
        }
    }
}
