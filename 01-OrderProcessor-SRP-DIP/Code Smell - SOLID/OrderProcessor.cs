using Code_Smell___SOLID.Apply_DIP_SRP.Interfaces;
using Code_Smell___SOLID.Apply_OCP.Interfaces;

namespace Code_Smell___SOLID
{
    internal class OrderProcessor
    {
        private readonly IOrderRepository _orderRepository;
        private readonly INotificationService _notificationService;

        public OrderProcessor(IOrderRepository orderRepository, INotificationService notificationService)
        {
            _orderRepository = orderRepository;
            _notificationService = notificationService;
        }
        public void ProcessOrder(IOrder order)
        {
            order.ProcessOrder();
            _orderRepository.Save();
            _notificationService.Send();
        }
    }
}
