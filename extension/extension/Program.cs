using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeDB;

namespace extension
{
    //Enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee(30004, "Anitha", 5000);
            emp1.Printemployeedetails();
            Console.WriteLine($"Annual package : {emp1.calculatorsalary()}");

            //emp1.calculatorsalary
            //here it is shown extension method is added to main program
            Console.ReadKey();
        }
    }
}
