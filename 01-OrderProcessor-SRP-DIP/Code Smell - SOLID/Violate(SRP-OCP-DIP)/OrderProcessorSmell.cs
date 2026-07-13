using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Smell___SOLID.Violate_SRP_OCP_DIP_
{
    internal class OrderProcessorSmell
    {
        public void ProcessOrder(string orderType, string email)
        {
            // 1. معالجة الطلب حسب نوعه
            if (orderType == "Digital")
            {
                Console.WriteLine("Processing Digital Order... Generating Download Link.");
            }
            else if (orderType == "Physical")
            {
                Console.WriteLine("Processing Physical Order... Printing Shipping Label.");
            }
            else
            {
                Console.WriteLine("Unknown Order Type!");
                return;
            }

            // 2. حفظ الطلب في قاعدة البيانات
            Console.WriteLine("Saving order details to SQL Database...");

            // 3. إرسال إيميل للعميل
            Console.WriteLine($"Sending confirmation email to {email}...");

        }
    }
}
