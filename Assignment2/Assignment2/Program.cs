using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(207, "Deepika", "ASP.NET");
            Student s2 = new Student(216, "Haritha", "c#");
            Student s3 = new Student(245, "Ruheen", "ASP.NET");
            Student s4 = new Student(201, "Kalyani", "c#");
            s1.Payment(1000);
            s1.Print();
            s2.Payment(1000);
            s2.Print();
            s3.Payment(2000);
            s3.Print();
            s4.Payment(2000);
            s4.Print();
            Console.ReadLine();
        }
    }
}
