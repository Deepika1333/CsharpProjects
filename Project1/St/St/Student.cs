using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
        private static double servicetax = 12.3;

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }
        public int DueAmount
        {
            get
            {
                return TotalFee - feepaid;
            }
        }
        public int TotalFee
        {
            get
            {
                double totalfee = course == "c#" ? 2000 : 3000;
        
                totalfee = totalfee + totalfee * ServiceTax / 100;

                return (int)totalfee;
            }
        }

        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
        
    }
}
