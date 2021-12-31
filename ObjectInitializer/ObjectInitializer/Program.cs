using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializer
{
    class Employee
    {
        public int Eno { set; get; }
        public string Ename { set; get; }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Eno = 101,
                Ename = "sow"
                
        };
        Console.WriteLine(e1.Eno); 
        }
    }
}
