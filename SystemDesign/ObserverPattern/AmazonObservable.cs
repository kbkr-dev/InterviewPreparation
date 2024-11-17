using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesign.Interfaces;

namespace SystemDesign.ObserverPattern
{
    public class AmazonObservable : IAmazonObservable
    {
        public List<IAmazonObserver> Observers = new List<IAmazonObserver>();
        private int _state = -1;
        public void Attach(IAmazonObserver observer)
        {
            Console.WriteLine("Attaching an observer");
            Observers.Add(observer);
        }

        public void Detach(IAmazonObserver observer)
        {
            Console.WriteLine("Detaching an observer");
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IAmazonObserver observer in Observers)
            {
                observer.update("Product is available now");
            }
        }

        public void SetData(int state)
        {
            _state = state;
            Notify();
        }
    }
}
