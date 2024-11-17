using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.AbstractFactoryPattern
{
    public class BajajFactory : VehicleAbstractFactory
    {
        public override IBike CreateBike()
        {
            return new BajajBike();
        }

        public override ICar CreateCar()
        {
            throw new NotImplementedException();
        }
    }
}
