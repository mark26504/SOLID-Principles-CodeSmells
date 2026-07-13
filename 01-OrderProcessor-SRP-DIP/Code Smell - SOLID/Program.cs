using Code_Smell___SOLID.Apply_DIP_SRP.Classes;
using Code_Smell___SOLID.Apply_OCP.Classes;
using Code_Smell___SOLID.Apply_OCP.Interfaces;

namespace Code_Smell___SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new DigitalOrder();

            OrderProcessor orderProcessor = new OrderProcessor(new OrderRepository(), new EmailNotification());

            orderProcessor.ProcessOrder(order);
        }
    }
}
