using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemDesign.Interfaces;

namespace SystemDesign.ObserverPattern
{
    public class AmazonObserver : IAmazonObserver
    {
        public void update(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
