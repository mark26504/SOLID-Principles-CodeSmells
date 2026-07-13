using Code_Smell___SOLID.Apply_DIP_SRP.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Smell___SOLID.Apply_DIP_SRP.Classes
{
    internal class EmailNotification : INotificationService
    {
        public void Send()
        {
            Console.WriteLine("Send Email...");
        }
    }
}
