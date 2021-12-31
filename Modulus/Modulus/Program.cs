using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulus
{
    class Program
    {
        public static  double ModuloOperation(int a,int b, int c)
        {
            double modulus = ((a % b) % c);
            return modulus;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.ModuloOperation(8, 5, 2));
        }
    }
}
