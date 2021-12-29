using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment
{
    class Bappointment
    {
        static void Main(string[] args)
        {
            Bappointment ba = new Bappointment();
            Console.WriteLine(ba.Schedule());
            Console.WriteLine(ba.PassAppointment());
            Console.ReadLine();
            static string Schedule()
            {
                List<string> AppointmentSchedule = new List<string>();
                AppointmentSchedule.Add("7/25/2019 13:45:00");
                foreach (var a in AppointmentSchedule)
                {
                    string b = Console.WriteLine(Split("7/25/2019 13:45:00", ,);
                    Console.ReadLine();
                }
            }
            static string PassAppointment()
            {
                List<string> Appointmenthaspassed = new List<string>();
                Appointmenthaspassed.Add("7/25/2019 13:45:00");
                foreach(var c in Appointmenthaspassed)
                {
                    Console.WriteLine(Appointmenthaspassed.Contains(c));
                    Console.ReadLine();
                }
            }
            static String AfternoonAppointment()
            {
                List<string> Appointmentinafternoon = new List<string>();
                Appointmentinafternoon.Add("7/25/2019 13:45:00");
                TimeSpan start = new TimeSpan(12, 0, 0);
                TimeSpan end = new TimeSpan(18, 0, 0);
                if(start<=end)
                {
                    Console.WriteLine("Appointment is booked in afternoon");
                    foreach(var i in Appointmentinafternoon)
                    {
                        Console.WriteLine(Appointmentinafternoon.Contains(i));
                        Console.ReadLine();
                    }
                }
            }
            static string Description()
            {
                List<string> Description = new List<string>();
                Description.Add("7/25/2019 13:45:00");
                foreach(var d in Description)
                {
                    Console.WriteLine("you have an appointment on {0}", d);
                    Console.ReadLine();
                }
            }
        }
    }
}
