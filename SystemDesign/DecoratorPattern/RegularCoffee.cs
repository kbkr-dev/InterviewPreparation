using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public class RegularCoffee : ICoffeeShop
    {
        public string GetDescription()
        {
            return "This is regular coffee";
        }

        public double GetPrice()
        {
            return 30;
        }
    }
}
