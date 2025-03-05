using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string HealthStatus { get; set; } // Здоров/нездоров

        // Конструктор без параметров
        public Pet()
        {
            Name = "Unknown";
            AnimalType = "Unknown";
            Age = 0;
            Weight = 0.0;
            HealthStatus = "Healthy";
        }

        // Конструктор с одним параметром
        public Pet(string name)
        {
            Name = name;
            AnimalType = "Unknown";
            Age = 0;
            Weight = 0.0;
            HealthStatus = "Healthy";
        }

        // Конструктор с параметрами
        public Pet(string name, string animalType, int age, double weight, string healthStatus)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
            Weight = weight;
            HealthStatus = healthStatus;
        }

        // Метод для вывода информации об объекте
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Animal Type: {AnimalType}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Health Status: {HealthStatus}");
            Console.WriteLine();
        }

        // Метод для изменения веса животного
        public void ChangeWeight(double newWeight)
        {
            Weight = newWeight;
            Console.WriteLine($"Updated weight of {Name} is now {Weight} kg.");
        }

        // Метод для изменения отметки о состоянии здоровья
        public void UpdateHealthStatus(string newStatus)
        {
            HealthStatus = newStatus;
            Console.WriteLine($"Updated health status of {Name} is now {HealthStatus}.");
        }
    }


}
