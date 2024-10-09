using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.DIP_right
{
    public class LightSwitch
    {
        private readonly ILight _light;

        // Зависимость теперь передается через конструктор
        public LightSwitch(ILight light)
        {
            _light = light;
        }

        public void Operate(string command)
        {
            if (command == "on")
            {
                _light.TurnOn();
            }
            else if (command == "off")
            {
                _light.TurnOff();
            }
        }
    }
}
