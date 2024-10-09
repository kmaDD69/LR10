using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.ISP_right
{
    public class MultiFunctionDevice : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }

        public void Fax()
        {
            Console.WriteLine("Sending fax...");
        }
    }
}
