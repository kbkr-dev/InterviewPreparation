using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.ObserverPattern
{
    public class NotificationService
    {
        public NotificationService(string title, string message)
        {
            this._title = title;
            this._message = message;
        }

        private string _title { get; set; } = string.Empty;
        private string _message { get; set; } = string.Empty;

        public void SetTitle(string value)
        {
            if (_title != value)
            {
                this._title = value;
                OnPushNotice(new PushNotificationEventArgs(_title, _message));
            }
        }


        public event EventHandler<PushNotificationEventArgs>? onPushNotification;

        
        

        protected virtual void OnPushNotice(PushNotificationEventArgs e)
        {
            onPushNotification?.Invoke(this, e);
        }
    }

    public class PushNotificationEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public PushNotificationEventArgs(string title, string message)
        {
            Title = title;
            Message = message;
        }
    }
}
