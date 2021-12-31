using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Temperature in Fahrenhiet is:" + TempConversion.Temp(20));
        }
        class TempConversion
        {
            public static double Temp(double C)
            {
                double F=0;
                if (C <= -271.15)
                {
                    Console.WriteLine("The Temperature does not exist");
                }
                else
                {
                    F = (C * 9 / 5) + 32;
                }
            return F;
            }
        }
    }     
 }
