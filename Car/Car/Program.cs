using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAssembly
{
    public class Program
    {

        public static void Main(string[] args)
        {
            AssemblyLine.SuccessRate(10);
            AssemblyLine.ItemsPerMinute(6);
            AssemblyLine.ItemsPerHour(6);
            Console.ReadLine();
        }
        static double SuccessRate(int speed)
        {
            Console.Write("Success Rate is \n");
            if (speed >=1 && speed < 5)
            {
                Console.WriteLine(0.10);
                return 0.10;
            }
            else if (speed >=5 && speed < 8)
            {
                Console.WriteLine(0.9);
                return 0.9;
            }


            else if (speed == 9)
            {
                Console.WriteLine(0.8);
                return 0.8;
            }

            else if (speed == 10)
            {
                Console.WriteLine(0.77);
                return 0.77;
            }
            else
            {
                Console.WriteLine(0);
                return 0;
            }
        }
        public static Double ItemsPerHour(int speed)
        {
            Console.WriteLine("Cars produced per hour:\n");
            int ProductionPerHour = 221;
            int h = ((ProductionPerHour) * 221);
            Console.WriteLine(h);
            return h;
        }
        public static double ItemsPerMinute(int speed)
        {
            Console.WriteLine(" Cars produced per minute:\\n");
            int ProductionPerHour = 221;
            double m = ((ProductionPerHour * (speed)) / 60);
            Console.WriteLine(m);
            return m;

        }
        
    }
}

