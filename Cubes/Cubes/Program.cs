using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubes
{
    class Program
    {
        public static Double Cube(Double a)
        {
            return a = a * a * a ;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Cube(8));
            Console.WriteLine(Program.Cube(5.5));
        }
    }
}
