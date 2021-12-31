using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyAppointment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(AppointmentSchedule());
            Console.WriteLine(AppointmentPassed());
            Console.WriteLine(AppointmentInAfternoon("AppointmentInAfternoon"));
        }
        static DateTime AppointmentSchedule()
        {
            Console.Write("7/25/2019 13:45:00");
            {
                Console.WriteLine(p);
                Console.ReadLine();

            }
        }
    }
    static AppointmentPassed()
    {
        List<string> AppointmentHasPassed = new List<string>();
        AppointmentHasPassed.Add("7/25/2019 13:45:00");
        foreach (var a in AppointmentHasPassed)
        {
            Console.WriteLine(a);
            Console.ReadLine();

        }//return 0;
    }
    public static AppointmentInAfternoon(string AppointmentInAfternoon)
    {
        List<string> AppointmentAfternoon = new List<string>();
        AppointmentAfternoon.Add("7/25/2019 13:45:00");
        TimeSpan Start = new TimeSpan(12, 0, 0);
        TimeSpan End = new TimeSpan(18, 0, 0);
        if (Start == End)
        {
            foreach (var b in AppointmentAfternoon)
            {
                Console.WriteLine(AppointmentAfternoon.Contains(b));
                Console.ReadLine();
            }
        }
    }
    public static Description(string Describe)
    {
        List<string> Description = new List<string>();
        Description.Add("7/25/2019 13:45:00");
        foreach (var d in Description)
        {
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}

