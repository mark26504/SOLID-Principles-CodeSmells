namespace Code_Smell___SOLID.Violate_SRP_OCP_DIP_
{
    internal class OrderProcessorSmell
    {
        public void ProcessOrder(string orderType, string email)
        {
            // 1. Process order based on its type
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

            // 2. Save order details to the database
            Console.WriteLine("Saving order details to SQL Database...");

            // 3. Send confirmation email to the customer
            Console.WriteLine($"Sending confirmation email to {email}...");
        }
    }
}