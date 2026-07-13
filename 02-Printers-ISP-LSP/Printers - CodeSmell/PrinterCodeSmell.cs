namespace Printers___CodeSmell
{
    internal class PrinterCodeSmell
    {
        internal interface IMachine
        {
            void Print(string document);
            void Scan(string document);
            void Fax(string document);
        }

        // 1. The advanced printer (Works perfectly fine, no issues)
        internal class MultiFunctionPrinter : IMachine
        {
            public void Print(string document) => Console.WriteLine($"Printing: {document}");
            public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
            public void Fax(string document) => Console.WriteLine($"Faxing: {document}");
        }

        // 2. The basic printer (Here is the disaster!)
        internal class BasicPrinter : IMachine
        {
            public void Print(string document) => Console.WriteLine($"Printing: {document}");

            public void Scan(string document)
            {
                // This machine doesn't even have a scanner!
                throw new NotImplementedException("This basic printer cannot scan!");
            }

            public void Fax(string document)
            {
                // This machine doesn't even have fax capabilities!
                throw new NotImplementedException("This basic printer cannot fax!");
            }
        }
    }
}