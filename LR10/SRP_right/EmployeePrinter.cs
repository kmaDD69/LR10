using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR10.SRP_right
{
    public class EmployeePrinter
    {
        public void PrintEmployeeDetails(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}