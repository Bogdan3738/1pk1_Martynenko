using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_2
{
    internal class Car
    {
        // Свойства
        public string LicensePlate { get; set; } // Номер авто
        public string Brand { get; set; }          // Марка
        public string Color { get; set; }          // Цвет
        public double CurrentSpeed { get; set; }   // Текущая скорость

        private const double MaxSpeed = 120; // Максимально допустимая скорость

        // Конструктор по умолчанию
        public Car()
        {
            LicensePlate = "Unknown";
            Brand = "Unknown";
            Color = "Unknown";
            CurrentSpeed = 0;
        }

        // Конструктор с параметрами
        public Car(string licensePlate, string brand, string color)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Color = color;
            CurrentSpeed = 0;
        }

        // Метод для симуляции ускорения
        public void Accelerate(double increment)
        {
            CurrentSpeed += increment;
            Console.WriteLine($"Ускорение: текущая скорость {CurrentSpeed} км/ч");

            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine("Скорость превышена! Автомобиль останавливается.");
                Brake();
            }
        }

        // Метод для торможения
        public void Brake()
        {
            CurrentSpeed = 0;
            Console.WriteLine("Автомобиль остановился.");
        }

        // Метод для отображения информации о машине
        public void DisplayInfo()
        {
            Console.WriteLine($"Номер авто: {LicensePlate}");
            Console.WriteLine($"Марка: {Brand}");
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Текущая скорость: {CurrentSpeed} км/ч");
        }
    }
}
