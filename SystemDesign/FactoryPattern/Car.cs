using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.FactoryPattern
{
    public class Car : IVehicle
    {
        public string Drive()
        {
            return "Im driving car";
        }

        public int GetTyres()
        {
            return 4;
        }
    }
}
