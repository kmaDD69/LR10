using LR10.OCP_right;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.OCP_right
{
    public class UsageExample
    {
        public void Main()
        {
            Employee regularEmployee = new RegularEmployee { Name = "John", Salary = 5000 };
            Employee manager = new Manager { Name = "Jane", Salary = 10000 };
            Employee director = new Director { Name = "Alice", Salary = 15000 };

            Console.WriteLine($"Regular Employee Bonus: {regularEmployee.CalculateBonus()}");
            Console.WriteLine($"Manager Bonus: {manager.CalculateBonus()}");
            Console.WriteLine($"Director Bonus: {director.CalculateBonus()}");
        }
    }
}
