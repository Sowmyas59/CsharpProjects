using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsResult
{
    class Program
    {
        public static  bool IsResultSame(double a,double b)
        {
            return a == b;

        }
        /*public static string Operations(double a,double b)
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
                Console.WriteLine("Denominator should be greater than 0");
            }
            return String.Format($"{sum},{diff},{prod},{div}");
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine(Program.IsResultSame(3 * 3, 4 + 5));
            Console.WriteLine(Program.IsResultSame(2 + 2, 3 * 2));
        }
    }
}
