using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Person
    {
        protected string firstName;
        protected string lastname;
        protected int idNumber;

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastname = lastName;
            this.idNumber = identification;
        }
         public void printPerson()
        {
            Console.WriteLine("Name: " + lastname + " , " + firstName + "\nID: " + idNumber);
        }
    }
}
