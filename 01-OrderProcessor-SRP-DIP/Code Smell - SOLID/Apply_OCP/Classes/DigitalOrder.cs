using Code_Smell___SOLID.Apply_OCP.Interfaces;

namespace Code_Smell___SOLID.Apply_OCP.Classes
{
    internal class DigitalOrder : IOrder
    {
        public void ProcessOrder()
        {
            Console.WriteLine("Processing Digital Order... Generating Download Link.");
        }
    }
}
