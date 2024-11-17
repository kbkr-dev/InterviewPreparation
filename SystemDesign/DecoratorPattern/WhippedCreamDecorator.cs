using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public class WhippedCreamDecorator : CoffeeShopDecorator
    {
        public WhippedCreamDecorator(ICoffeeShop coffeeShop) : base(coffeeShop)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription()+", Whipped Cream";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 20;
        }
    }
}
