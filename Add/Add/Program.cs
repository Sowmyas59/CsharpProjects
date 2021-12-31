using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add
{
    public class AddAndMultiplyTask
    { 
    public static double AddAndMultiply(double a, double b, double c)
    {
        double result = 0;
        result = (a + b) * c;
        Console.WriteLine("result=" + result);
        return result;
    }
    static void Main(string[] args)
        {
            AddAndMultiplyTask.AddAndMultiply(10, 20, 30);
            //Console.WriteLine(AddAndMultiply(10, 20, 30));
        }
       
    }
}
