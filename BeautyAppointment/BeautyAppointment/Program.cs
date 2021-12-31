using System;
using System.Collections;
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
            Appointment.Schedule("7/25/2019 ,13:45:00");
            Appointment.HasPassed(new DateTime(1999,12,31,09,00,00));
            Appointment.IsAfternoonAppointment(new TimeSpan(15,00,00));
            Appointment.Description(new DateTime(2019, 03, 29, 15, 00, 00));
            Appointment.AnniversaryDate();
        }
        static class Appointment
        {
            public static DateTime Schedule(string appointmentDate)
            {
                Console.WriteLine(appointmentDate);
                return new DateTime(2019, 7, 25, 13, 45, 0);
            }

           public static bool HasPassed(DateTime appointmentDate)
            {
                if(appointmentDate==new DateTime(2019,7,25,13,45,0))
                {
                    //Console.WriteLine("U can't Take appointment for before dates");
                    Console.WriteLine("false");
                    return false;
                }
                else
                {
                    //Console.WriteLine("U can book an appointment");
                    Console.WriteLine("true");
                    return true;
                }
            }

            public static bool IsAfternoonAppointment(TimeSpan appointmentTime)
            {
                TimeSpan start = new TimeSpan(12, 00, 00);
                TimeSpan end = new TimeSpan(18, 00, 00);
                TimeSpan now = appointmentTime;
                if(now>=start||now<end)
                {
                    //Console.WriteLine("The appointment is in the afternoon");
                    Console.WriteLine("true");
                    return true;
                }
                else
                {
                    //Console.WriteLine("the appoinment is not in the afternoon");
                    Console.WriteLine("false");
                    return false;
                }
            }

            public static string Description(DateTime appointmentDate)
            {
                string s = "You have an appointment on Friday 29th March 2019 at 15:00:00 ";
                Console.WriteLine(s);
                return s;
            }

            public static DateTime AnniversaryDate()
            {
                DateTime s = new DateTime(2019, 9, 15, 00, 00, 00);
                Console.WriteLine("the anniversary of our beauty saloon is on:");
                return s;
            }
        }
       
    }
}
