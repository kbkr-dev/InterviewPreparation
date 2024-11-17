using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.ObserverPattern
{
    public class Observer
    {
        private readonly string _appName;

        // Constructor
        public Observer(string appName)
        {
            _appName = appName;
        }

        // Method to handle notifications
        public void ReceivedNotification(object sender, PushNotificationEventArgs e)
        {
            Console.WriteLine($"Notification Received for application {_appName}: Product {e.Title} is now {e.Message}");
        }

        public void ReceivedDelegateNotification(string title, string message)
        {
            Console.WriteLine($"Notification Received for application {_appName}: Product {title} is now {message}");
        }
    }
}
