using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.OCP_right
{
    public class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.2; // Бонус для менеджера
        }
    }
}
