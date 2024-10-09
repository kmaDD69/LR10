using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.OCP_right
{
    public class Director : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.3; // Бонус для директора
        }
    }
}
