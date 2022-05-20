using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1
{
    // Данная программа использует марку и модель автомобиля в качестве вводных данных
    // и определяет класс Vehicle со свойством Model и методом ShowModel()
    // Завершите класс Cat для наследования класса Vehicle и добавления свойства Model,
    // а также метода ShowModel(), чтобы данный вызов метода объекта Car работал корректно

    internal class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();

            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public string Brand { get; set; }
        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }

    class Car : Vehicle
    {
        public string Model { get; set; }
        public void ShowModel()
        {
            Console.WriteLine("Model: " + Model);
        }
    }
}
