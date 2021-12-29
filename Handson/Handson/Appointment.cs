using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson
{
    class Appointment
    {
        public static string Schedule(List<string> obj, string dateTime)
        {
            obj.Add(dateTime);
            string[] Date = dateTime.Split(' ');
            string[] date = Date[0].Split('/');
            string[] time = Date[1].Split(':');

            return date[2] + "," + date[0] + "," + time[0] + "," + time[1] + "," + time[2];
        }
        public static bool Haspassed(List<string> obj, string dateTime)
        {
            bool isNot = true;
            foreach(var i in obj)
            {
                isNot = false;
            }
            return isNot;
        }
        public static bool isAfternoonAppointment(string dateAndTime)
        {
            bool isAfternoon = false;
            string[] dateTimeArray = dateAndTime.Split(' ');
            string[] time = dateTimeArray[1].Split(':');
            if (Convert.ToInt32(time[0]) > 12 && Convert.ToInt32(time[0]) < 18)
            {
                isAfternoon = true;
            }
            return isAfternoon;
        }
        public static void Description(string dateAndTime)
        {
            Console.WriteLine("Appointment Date " + dateAndTime);
        }
    }
}
