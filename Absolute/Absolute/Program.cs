using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute
{
    class Program
    {
        public static int AbsoluteNum(int a)
        {
            if(a==(-a))
            {
                a = +a;
                return a;
            }
            else
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.AbsoluteNum(-30));
            Console.WriteLine(Program.AbsoluteNum(-10));
        }
    }
}
