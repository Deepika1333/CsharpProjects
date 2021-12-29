using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment a1 = new Appointment();
            List<String> obj = new List<string>();
            obj.Add("7/25/2019 13:45:00");
            Console.WriteLine("enter appointment Date and time");
            string dateAndTime = Console.ReadLine();
            bool Ticket = Appointment.Haspassed(obj, dateAndTime);
            if(Ticket==true)
            {
                Console.WriteLine("Appointment is on another date");
            }
            else
            {
                Console.WriteLine("DateAndTime{0}", Appointment.Schedule(obj, dateAndTime));
                Appointment.Description(dateAndTime);
            }
            Console.ReadKey();
        }
    }
}
