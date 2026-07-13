using Printers___CodeSmell.ISP.Interfaces;

namespace Printers___CodeSmell.LSP
{
    internal class BasicPrinter : IPrinter
    {
        public void Print(string document)
            => Console.WriteLine($"Printing: {document}");
    }
}
