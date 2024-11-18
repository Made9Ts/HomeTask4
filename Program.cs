using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация сервисов
            INotificationService notificationService = new NotificationService();
            OrderManager orderManager = new OrderManager(notificationService);

            // Создание и обновление заказа
            orderManager.CreateOrder(1, "Иван Иванов");
            orderManager.UpdateOrderStatus(1, "Отправлен");

            orderManager.CreateOrder(2, "Мария Петрова");
            orderManager.UpdateOrderStatus(2, "Доставлен");
        }
    }
}
