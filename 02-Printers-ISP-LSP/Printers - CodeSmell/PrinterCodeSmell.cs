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

        // 2. الماكينة الغالية (شغالة تمام ومفيهاش مشكلة)
        internal class MultiFunctionPrinter : IMachine
        {
            public void Print(string document) => Console.WriteLine($"Printing: {document}");
            public void Scan(string document) => Console.WriteLine($"Scanning: {document}");
            public void Fax(string document) => Console.WriteLine($"Faxing: {document}");
        }

        // 3. الماكينة الرخيصة (هنا الكارثة!)
        internal class BasicPrinter : IMachine
        {
            public void Print(string document) => Console.WriteLine($"Printing: {document}");

            public void Scan(string document)
            {
                // الماكينة دي مفيهاش سكانر أصلاً!
                throw new NotImplementedException("This basic printer cannot scan!");
            }

            public void Fax(string document)
            {
                // الماكينة دي مفيهاش فاكس أصلاً!
                throw new NotImplementedException("This basic printer cannot fax!");
            }
        }
    }
}

