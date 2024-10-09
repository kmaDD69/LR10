using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.ISP_right
{
    public class UsageExample
    {
        public void Main()
        {
            Printer printer = new Printer();
            Scanner scanner = new Scanner();
            MultiFunctionDevice multiDevice = new MultiFunctionDevice();

            printer.Print();
            scanner.Scan();
            multiDevice.Print();
            multiDevice.Scan();
            multiDevice.Fax();
        }
    }
}
