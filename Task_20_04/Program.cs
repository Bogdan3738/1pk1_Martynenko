namespace Task_20_04
{
    /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
• Car
• Bike
• Bus
• Truck
• Motorcycle
Храните список транспортных средств (можно просто List<VehicleType>).
    Добавьте метод для подсчёта транспорта определённого типа
    (например, сколько грузовиков). Реализуйте поиск по типу и вывод информации.
     
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistry registry = new VehicleRegistry();

            // Добавляем транспортные средства
            registry.AddVehicle(VehicleType.Car);
            registry.AddVehicle(VehicleType.Bike);
            registry.AddVehicle(VehicleType.Bus);
            registry.AddVehicle(VehicleType.Truck);
            registry.AddVehicle(VehicleType.Motorcycle);
            registry.AddVehicle(VehicleType.Truck); // Добавляем еще один грузовик

            // Выводим список всех транспортных средств
            registry.DisplayVehicles();

            // Подсчёт количества грузовиков
            int truckCount = registry.CountVehicles(VehicleType.Truck);
            Console.WriteLine($"Количество грузовиков: {truckCount}");

            // Подсчёт количества мотоциклов
            int motorcycleCount = registry.CountVehicles(VehicleType.Motorcycle);
            Console.WriteLine($"Количество мотоциклов: {motorcycleCount}");
        }
    }
}
