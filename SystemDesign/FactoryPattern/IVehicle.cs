using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.FactoryPattern
{
    public interface IVehicle
    {
        int GetTyres();
        string Drive();
    }
}
