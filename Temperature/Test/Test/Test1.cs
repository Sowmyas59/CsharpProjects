using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public class Student
        {
            public string name;
            public string rollnumber; public string course;
            public int feepaid;
            public int totalfee;
            public Student(string name, string rollnumber, string course)
            {
                Console.WriteLine("student name:" + name);
                Console.WriteLine("student roll number :" + rollnumber);
                Console.WriteLine("student course:" + course);

            }
            public void payment(int amount)
            {
                feepaid = feepaid + amount;
            }
            public void print()
            {
                Console.WriteLine(name);
                Console.WriteLine(rollnumber);
                Console.WriteLine(course );
                Console.WriteLine(feepaid);
            }
            public int dueamountproporty
            {
                get
                {

                    return Totalfee - feepaid;
                }


            }


            public int Totalfee
            {
                get
                {
                    return course == "c#" ? 2000 : 3000;

                }
            }

        }
        static void Main(string[] args)
            {
                Console.WriteLine("enter student name:");
                string name = Console.ReadLine();
                Console.WriteLine("enter student rollnumber:");
                string rollnumber = (Console.ReadLine());
                Console.WriteLine("enter student course:");
                string course = Console.ReadLine();
                Console.WriteLine("enter paid amount:");
                int amount = Convert.ToInt32(Console.ReadLine());
                Student studentobj = new Student(name, rollnumber, course);
                studentobj.payment(amount);
                studentobj.print();
                Console.WriteLine(studentobj.dueamountproporty);
                Console.WriteLine();
                Console.ReadKey();
            }
        }
}

