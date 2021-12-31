using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("id\t"+source\t\tdestination\tdate\t\t+status\tnetwork\t");
            FileStream fs = new FileStream("C:\\Capgemini\\csharp.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            while (sr.Peek() > 0)
            {
                
                string line = sr.ReadLine();
                string[] strings = line.Split(':');

                if (strings.Length > 1)
                {
                    Console.WriteLine(strings[1] + "\t");
                }
                else
                {
                    Console.WriteLine();
                }
                
                    
            }
            
        }
    }
}
