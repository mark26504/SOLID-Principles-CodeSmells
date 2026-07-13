using Code_Smell___SOLID.Apply_OCP.Interfaces;

namespace Code_Smell___SOLID.Apply_OCP.Classes
{
    internal class PhysicalOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing Physical Order... Printing Shipping Label.");
        }
    }
}
