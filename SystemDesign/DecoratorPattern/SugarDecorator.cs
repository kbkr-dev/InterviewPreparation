using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public class SugarDecorator : CoffeeShopDecorator
    {
        public SugarDecorator(ICoffeeShop coffeeShop) : base(coffeeShop)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sugar";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 2;
        }
    }
}
