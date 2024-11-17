using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.Interfaces
{
    public interface IAmazonObserver
    {
        void update(string message);
    }
}
