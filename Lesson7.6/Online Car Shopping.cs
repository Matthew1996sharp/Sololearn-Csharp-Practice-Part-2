using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._6
{
    // На сайте дилера автомобилей вы можете сделать предзаказ автомобиля,
    // указав его цвет и комплектацию
    // Данная программа берет цвет и комплектацию в качестве вводных данных
    // и передает их в конструктор уже заявленного класса Car
    // Внедрите интерфейсы IColor и IEquipment для класса Car
    // и переопределите их методы GetCpolor и GetEquipment внутри.
    // Каждый из них должен выводить соответстсвующие сообщения о цвете и комплектации

    internal class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();

            Console.ReadKey();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }

    public class Car : IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }

        public void GetColor()
        {
            Console.WriteLine("Color: " + color);
        }

        public void GetEquipment()
        {
            Console.WriteLine("Equipoment: " + equipment);
        }
    }
}
