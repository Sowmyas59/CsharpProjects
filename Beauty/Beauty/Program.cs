using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beauty
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Appointment.HasPassed(DateTime.Now));
            
            Console.ReadLine();
        }
            static class Appointment
            {
            public static DateTime Schedule(string appointmentDateDescription)
            {
                DateTime Now = DateTime.Now;
                String AppoinmentDate;
                Console.WriteLine("Please enter the date and time of appointment");
               
                throw new NotImplementedException("Please implement the (static) Appointment.Schedule() method");
                Console.ReadLine();
            }

            public static bool HasPassed(DateTime appointmentDate)
            {
                if(appointmentDate<DateTime.Now)
                {
                    Console.WriteLine("Appointment cannot be made");
                }
                throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
            }

            public static bool IsAfternoonAppointment(DateTime appointmentDate)
            {
                
                throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
            }

            public static string Description(DateTime appointmentDate)
            {
                throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
            }

            public static DateTime AnniversaryDate()
            {
                throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
            }
        }
    }
}
