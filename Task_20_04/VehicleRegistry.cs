using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    public class VehicleRegistry
    {
        private List<VehicleType> _vehicles;

        public VehicleRegistry()
        {
            _vehicles = new List<VehicleType>();
        }
        public void AddVehicle(VehicleType vehicle)
        {
            _vehicles.Add(vehicle);
        }

        // Метод для подсчета транспортных средств определённого типа
        public int CountVehicles(VehicleType vehicleType)
        {
            return _vehicles.Count(v => v == vehicleType);
        }

        // Метод для вывода информации о всех транспортных средствах
        public void DisplayVehicles()
        {
            Console.WriteLine("Список транспортных средств:");
            foreach (var vehicle in _vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
