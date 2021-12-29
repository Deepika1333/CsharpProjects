using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int idNumber;

        Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.idNumber = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + " , " + firstName + "\nID: " + idNumber);
        }
    }
}
