using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.SRP_wrong
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public void CalculateSalary(int hoursWorked)
        {
            Salary = hoursWorked * 20; // Простой расчет зарплаты
        }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
        }
    }
}
