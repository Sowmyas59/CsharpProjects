using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    class Program
    {
        public static string Swap(double a,double b)
        {
            Console.WriteLine("First the numbers where" + a + "and" + b);
            double temp = 0;
            temp = b;
            b = a;
            a = temp;
            return String.Format($"After swapping a={a}\t , b={b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Swap(10, 20));
            Console.WriteLine(Program.Swap(-10, 20));
        }
    }
}
