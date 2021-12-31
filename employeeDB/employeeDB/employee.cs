using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeDB
{
   
    
        public class employee
        {
            public int employeeId { get; set; }
            public string employeeName { get; set; }
            public int employeesalary { get; set; }
            public employee(int empId, string empName, int salary)
            {
                employeeId = empId;
                employeeName = empName;
                employeesalary = salary;
            }
            public void Printemployeedetails()
            {
                Console.WriteLine($"EmpNo : {employeeId}");
                Console.WriteLine($"EmpName : {employeeName}");
            }
        }

    }

