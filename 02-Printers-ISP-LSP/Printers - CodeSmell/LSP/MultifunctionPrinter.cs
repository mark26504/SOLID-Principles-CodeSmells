using Printers___CodeSmell.ISP.Interfaces;

namespace Printers___CodeSmell.LSP
{
    internal class MultifunctionPrinter : IScanner, IFax, IPrinter
    {
        public void Print(string document)
            => Console.WriteLine($"Printing: {document}");

        public void Scan(string document)
            => Console.WriteLine($"Scanning: {document}");

        public void SendFax(string document)
            => Console.WriteLine($"Faxing: {document}");
    }
}
