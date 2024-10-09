using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.DIP_right
{
    public class LEDLight : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine("The LED light is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("The LED light is off.");
        }
    }
}
