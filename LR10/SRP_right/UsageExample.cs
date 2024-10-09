using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.SRP_right
{
    public class UsageExample
    {
        public void Main()
        {
            Employee employee = new Employee { Name = "John Doe" };
            SalaryCalculator calculator = new SalaryCalculator();
            EmployeePrinter printer = new EmployeePrinter();

            employee.Salary = calculator.CalculateSalary(40); // Расчет зарплаты
            printer.PrintEmployeeDetails(employee); // Печать информации о сотруднике
        }
    }
}
