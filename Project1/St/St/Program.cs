using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(207, "chikku", "c#");
            s1.Payment(1000);
            s1.Print();
            Console.WriteLine(s1.DueAmount);
            Student s2 = new Student(216, "deepu", "ASP.net");
            s2.Payment(1000);
            s2.Print();
            Console.WriteLine(s2.DueAmount);
            Console.ReadLine();
        }
    }
}
