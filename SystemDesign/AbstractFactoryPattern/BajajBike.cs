using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.AbstractFactoryPattern
{
    public class BajajBike : IBike
    {
        public void Drive()
        {
            Console.WriteLine("Im driving bajaj bike");
        }
    }
}
