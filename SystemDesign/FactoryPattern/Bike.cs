using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.FactoryPattern
{
    public class Bike : IVehicle
    {
        public string Drive()
        {
            return "Im riding bike";
        }

        public int GetTyres()
        {
            return 2;
        }
    }
}
