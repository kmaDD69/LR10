using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.DIP_right
{
    public class UsageExample
    {
        public void Main()
        {
            ILight bulb = new LightBulb();
            ILight ledLight = new LEDLight();

            LightSwitch lightSwitch = new LightSwitch(bulb);
            lightSwitch.Operate("on");
            lightSwitch.Operate("off");

            // Легко переключаемся на другой источник света
            lightSwitch = new LightSwitch(ledLight);
            lightSwitch.Operate("on");
            lightSwitch.Operate("off");
        }
    }
}
