using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjInitializer
{ 
    class Employee
    { 
            public int Eno { set; get; }
            public string Ename { set; get; }
        }
        class Program
        {
            static void Main()
            {
                Employee e1 = new Employee(){Eno = 101,Ename="sam"};
                Console.WriteLine(e1.Eno);
                Console.WriteLine(e1.Ename);
                Employee e2 = new Employee(){Eno = 102};
                Console.WriteLine(e2.Eno);
                Employee e3 = new Employee(){Ename = "Tom"};
                Console.WriteLine(e3.Ename);
            }
        }
 }
