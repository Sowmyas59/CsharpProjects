using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1
{
    class Program
    {
        public class Person
        {
            public String name;
            public String ID;
            public int numSub;
            public int[] scores;
        }
        public class Student : Person
        {
            public Student(String name, String ID, int sub, int[] scores)
            {
                this.name = name;
                this.ID = ID;
                this.numSub = sub;
                scores = new int[sub];
                for (int i = 0; i < sub; i++)
                {
                    this.scores[i] = scores[i];
                }
                Console.WriteLine("Name: " + this.name);
                Console.WriteLine("ID: " + this.ID);
            }
            public char calculates()
            {
                int sum = 0;
                for (int i = 0; i < this.numSub; i++)
                {
                    sum += this.scores[i];
                }
                char ch = '';
                int avg = sum / this.numSub;
                if (avg >= 90 && avg <= 100)
                {
                    ch = 'O';
                }
                else if (avg >= 80 && avg < 90)
                {
                    ch = 'E';
                }
                else if (avg >= 70 && avg < 80)
                {
                    ch = 'A';
                }
                else if (avg >= 55 && avg < 70)
                {
                    ch = 'P';
                }
                else if (avg >= 40 && avg < 55)
                {
                    ch = 'D';
                }
                else if (avg >= 0 && avg < 40)
                {
                    ch = 'T';
                }
                return ch;
            }
        }
        class HelloWorld
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter student name");
                String name = Console.ReadLine();
                if (name.Length < 1 || name.Length > 10)
                {
                    Console.WriteLine("0 < characters < 11 : Re-Enter");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Enter the Id");
                String ID = Console.ReadLine();
                if (ID.Length != 7)
                {
                    Console.WriteLine("characters=7 : Re-Enter");
                    ID = Console.ReadLine();
                }
                Console.WriteLine("Enter the number of subjects");
                int sub = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the scores");
                int[] scores = new int[sub];
                for (int i = 0; i < sub; i++)
                {
                    scores[i] = int.Parse(Console.ReadLine());
                    if (scores[i] < 0 || scores[i] > 100)
                    {
                        Console.WriteLine("-1 < score < 101 : Re-Enter");
                        scores[i] = int.Parse(Console.ReadLine());
                    }
                }
                Student s = new Student(name, ID, sub, scores);
                Console.WriteLine("Grade: " + s.calculates());
            }
        }
    }
}





