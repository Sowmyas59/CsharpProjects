using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayListObjects
{
    class Program
        {
            public static void Main(string[] args)
            {
                ArrayList list = new ArrayList();
                int n= 3;
                Console.WriteLine("enter the details of three people ");
                for (int i = 0; i < n; i++)
                {
                    string name = Console.ReadLine();
                    int age = int.Parse(Console.ReadLine());

                    list.Add(new Person()
                    {
                        Name = name,
                        Age = age
                    });
                }
                foreach (Person p in list)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.ReadLine();
            }
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
                public override string ToString()
                {
                    return Name + " - " + Age;
                }
            }
        }
}
