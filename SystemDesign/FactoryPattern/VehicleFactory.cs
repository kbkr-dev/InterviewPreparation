using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            return vehicleType.ToLower() switch
            {
                "car" => new Car(),
                "bike" => new Bike(),
                _ => throw new ArgumentException("Invalid vehicle type")
            };

        }
    }
}
