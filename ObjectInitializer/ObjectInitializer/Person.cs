using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    public int id;
    public string FirstName;
    public string LastName;
    public DateTime BirthDate;
    public Person(int id)
    {

    }
    public Person(int id, string Firstname)
    {

    }
    public Person(int id, string FirstName, string LastName)
    {

    }
    public Person(int id, DateTime BirthDate)
    {

    }


    static void Main()
    {
        Person person = new Person(10);
        Console.WriteLine(person);
        Person p = new Person(10, "sam");
        Console.WriteLine(p);
        Person per = new Person(10, "sam", "daniel");
        Console.WriteLine(per);
        Person persons = new Person(01 / 11 / 2009);
        Console.WriteLine(persons);
    }

}