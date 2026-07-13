using Printers___CodeSmell.ISP.Interfaces;
using Printers___CodeSmell.LSP;

namespace Printers___CodeSmell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter bPrinter = new BasicPrinter();
            bPrinter.Print("Basic Printer!");

            IScanner mFPrinter = new MultifunctionPrinter();
            mFPrinter.Scan("Multifunction Printer!");

            IFax faxPrinter = new MultifunctionPrinter();
            faxPrinter.SendFax("Multifunction Printer!");
        }
    }
}
