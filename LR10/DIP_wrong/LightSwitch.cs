using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.DIP_wrong
{
    public class LightSwitch
    {
        private LightBulb _lightBulb;

        public LightSwitch()
        {
            _lightBulb = new LightBulb();
        }

        public void Operate(string command)
        {
            if (command == "on")
            {
                _lightBulb.TurnOn();
            }
            else if (command == "off")
            {
                _lightBulb.TurnOff();
            }
        }
    }
}
