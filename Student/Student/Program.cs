using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails JohnStudentDetails = new StudentDetails(1001, "John", "c#");
            StudentDetails JaneStudentDetails = new StudentDetails(1002, "Jane", "ASP.NET");
            JohnStudentDetails.Payment(200);
            JaneStudentDetails.Payment(100);
            JohnStudentDetails.Print();
            Console.WriteLine("\n");
            JaneStudentDetails.Print();
        }
    }
    class StudentDetails
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public int FeePaidSoFar { get; set; }
        public double DueAmount
        {
            get
            {
                return TotalFee - FeePaidSoFar;
            }
        }
        public double TotalFee
        {
            get
            {
                if (CourseJoined.ToLower() == "c#")
                {
                    double n = 2000+(2000 * 0.123);
                    return n;
                }
                else if (CourseJoined.ToLower() == "asp.net")
                {
                    double n = 3000+(3000 * 0.123);
                    return n;
                }
                return 0;
            }
        }
        public StudentDetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }
        public void Payment(int amount)
        {
            FeePaidSoFar += amount;
        }
        public class Tax
        {
            public double ServiceTax { get; set; }
            public double DueAmount { get; set; }
            public double TotalFee
            {
                get
                {
                    return DueAmount = DueAmount * ServiceTax;
                }
            }
            public Tax()
            {
                ServiceTax = 0.123;
            }
        }
        public void Print()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Roll No: {RollNo}");
            Console.WriteLine($"Course Joined: {CourseJoined}");
            Console.WriteLine($"Total Fee: {TotalFee}");
            Console.WriteLine($"Fee Paid So Far: {FeePaidSoFar}");
            Console.WriteLine($"Due Amount: {DueAmount}");
        }
    }
}

