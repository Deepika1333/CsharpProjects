using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;

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
            Console.WriteLine("Roll No: {0}", rollno);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("course joined:{0}", course);
            Console.WriteLine("Fee paid: {0}", feepaid);
            Console.WriteLine("DueAmount: {0}", DueAmount);
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
                return course == "c#" ? 2000 : 3000;

            }
        }
    }
}
