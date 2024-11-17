using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public abstract class CoffeeShopDecorator : ICoffeeShop
    {
        private readonly ICoffeeShop _coffeeShop;

        public CoffeeShopDecorator(ICoffeeShop coffeeShop)
        {
            _coffeeShop = coffeeShop;
        }
        public virtual string GetDescription()
        {
            return _coffeeShop.GetDescription();
        }

        public virtual double GetPrice()
        {
            return _coffeeShop.GetPrice();
        }
    }
}
