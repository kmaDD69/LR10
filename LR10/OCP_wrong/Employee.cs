using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.OCP_wrong
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        public double CalculateBonus()
        {
            if (Position == "Manager")
            {
                return Salary * 0.2; // Бонус для менеджера
            }
            else
            {
                return Salary * 0.1; // Бонус для обычного сотрудника
            }
        }
    }

}
