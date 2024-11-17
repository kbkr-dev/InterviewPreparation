using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.AbstractFactoryPattern
{
    public abstract class VehicleAbstractFactory
    {
        public abstract IBike CreateBike();
        public abstract ICar CreateCar();

        public virtual void DisplayCreationMessage()
        {
            Console.WriteLine("Manufacturing Vehicles..");
        }
    }
}
