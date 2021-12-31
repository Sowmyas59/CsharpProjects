using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employeeDB;
//we must use  namespsce of which we need to extension that file name

namespace extension
{
    //must be defined static class and static method  
    public static class helper
    {
        // and here we use this keyword and the class name that we create in employeeDB
        public static int calculatorsalary(this employee empobj)
        {
            var sal = empobj.employeesalary;
            int pf = 2000; 
            int wifibill = 1000;
            int annualsalary = (sal + pf + wifibill) * 12; 
            return annualsalary ;
        }
    }
}

