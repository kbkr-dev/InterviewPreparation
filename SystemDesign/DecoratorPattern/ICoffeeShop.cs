using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.DecoratorPattern
{
    public interface ICoffeeShop
    {
        string GetDescription();
        double GetPrice();
    }
}
