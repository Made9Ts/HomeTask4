using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"[Уведомление]: {message}");
        }
    }
}
