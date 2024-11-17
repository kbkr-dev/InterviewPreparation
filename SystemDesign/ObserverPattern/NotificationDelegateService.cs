using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.ObserverPattern
{
    public delegate void PushNotificationDelegate(string title, string message);
    public class NotificationDelegateService
    {
        private string _title = string.Empty;
        private string _message = string.Empty;

        public PushNotificationDelegate? NotifyObservers;

        public NotificationDelegateService(string title, string message)
        {
            _title = title;
            _message = message;
        }

        public void SetTitle(string value)
        {
            if (_title != value)
            {
                _title = value;
                Notify(_title, _message);
            }
        }

        private void Notify(string title, string message)
        {
            NotifyObservers?.Invoke(title, message);
        }
    }
}
