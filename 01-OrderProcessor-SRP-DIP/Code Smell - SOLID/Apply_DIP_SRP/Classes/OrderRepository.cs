using Code_Smell___SOLID.Apply_DIP_SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Smell___SOLID.Apply_DIP_SRP.Classes
{
    internal class OrderRepository : IOrderRepository
    {
        public void Save()
        {
            Console.WriteLine("Save Order To Database...");
        }
    }
}
