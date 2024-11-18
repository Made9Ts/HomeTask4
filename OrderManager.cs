using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeTask4;

namespace HomeTask4
{
    public class OrderManager
    {
        private readonly INotificationService _notificationService;
        private readonly Dictionary<int, string> _orders;

        public OrderManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
            _orders = new Dictionary<int, string>();
        }

        public void CreateOrder(int orderId, string customerName)
        {
            if (_orders.ContainsKey(orderId))
            {
                throw new InvalidOperationException("Order ID already exists.");
            }

            _orders[orderId] = "Created";
            _notificationService.SendNotification($"Заказ {orderId} для клиента {customerName} создан.");
        }

        public void UpdateOrderStatus(int orderId, string status)
        {
            if (!_orders.ContainsKey(orderId))
            {
                throw new KeyNotFoundException("Order ID not found.");
            }

            _orders[orderId] = status;
            _notificationService.SendNotification($"Статус заказа {orderId} обновлён на: {status}.");
        }
    }
}
