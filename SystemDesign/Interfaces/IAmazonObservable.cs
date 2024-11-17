using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.Interfaces
{
    public interface IAmazonObservable
    {
        void Attach(IAmazonObserver observer);
        void Detach(IAmazonObserver observer);
        void Notify();
        void SetData(int state);
    }
}
