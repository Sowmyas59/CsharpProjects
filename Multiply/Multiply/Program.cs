using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> lists = new List<int>(new int[] { 1 , 2 , 3 , 4 });
            for(int k=0;k<lists.Count;k++)
            {
                int result = (lists[k] += 2);
            }
            foreach(var item in lists)
            {
                Console.WriteLine(item * 5);
            }
            //Console.ReadKey();*/
            List<string> s = new List<string>(new string[] { "1", "2", "3", "4" });
            for(int j=0;j<s.Count;j++)
            {
                string res = s[j]+s[j]+s[j]+s[j];
                Console.WriteLine(res);
            }
            /*String ch[]= "abc", "cdaef", "js", "php";
            for(int i=0;i<c.Count;i++)
            {
                List<string> a=new List(new string[]{ "a" });
                Console.Write(a);

            }
            List<string> c = new List<string>(new string[] { "abc", "cdaef", "js", "php" });
            
            int i;
            
            //Convert.ToChar(a);
            for (i=0;i < c.Count; i++ )
            {

                c.Remove("a");

                Console.WriteLine("\n"+c[i]);
                
            }*/
        }
    }
}