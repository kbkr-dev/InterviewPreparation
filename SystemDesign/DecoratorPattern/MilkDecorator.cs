using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public class MilkDecorator : CoffeeShopDecorator
    {
        public MilkDecorator(ICoffeeShop coffeeShop) : base(coffeeShop)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Milk";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}
