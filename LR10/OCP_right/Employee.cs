using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.OCP_right
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public abstract double CalculateBonus(); // Оставляем метод для переопределения
    }
}
