using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.AbstractFactoryPattern
{
    public class HyundaiCar : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Im driving hyundai car");
        }
    }
}
