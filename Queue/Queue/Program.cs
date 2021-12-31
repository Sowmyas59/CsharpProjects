using System;
using System.Collections;

public class QueueObjects
{
    public static void Main(string[] args)
    {
        QueueObjects QueueObjects = new QueueObjects();
        int total = 3;

        for (int i = 0; i < total; i++)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            QueueObjects.Enqueue(new Person()
            {
                Name = name,
                Age = age
            });
        }

        for (int i = 0; i < total; i++)
        {
            Person p = (Person)QueueObjects.Dequeue();
            Console.WriteLine(p.ToString());
        }
    }

    private Person Dequeue()
    {
        throw new NotImplementedException();
    }

    private static void Enqueue(Person person)
    {
        throw new NotImplementedException();
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