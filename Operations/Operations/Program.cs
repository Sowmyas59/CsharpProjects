using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        public static string ElementaryOperations(double a,double b)
        {
            double sum = a + b;
            double diff = a - b;
            double prod = a * b;
            double div = 0;
            if(b!=0)
            {
                div = a / b;
            }
            else
            {
                Console.WriteLine("Denominator cannot be 0");
            }
            return String.Format($"a+b={sum},a-b={diff},a*b={prod},a/b={div}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ElementaryOperations(10,20));

        }
    }

}
