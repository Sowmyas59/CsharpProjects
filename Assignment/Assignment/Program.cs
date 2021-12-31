using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Id\t" + "source\t\t" + "destination\t\t" + "date\t" + "status\t"  + "network\t");
            FileStream fs = new FileStream("C:\\Capgemini\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while(sr.Peek()>0)
            {
                string line = sr.ReadLine();
                string[] strings = line.Split(':');
                if(strings.Length>1)
                {
                    Console.Write(strings[1] + "\t");
                }
                else
                {
                    Console.WriteLine();

                }
            }
        }
    }
}
