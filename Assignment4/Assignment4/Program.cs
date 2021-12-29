using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of scores: ");
            int numScores = int.Parse(Console.ReadLine());
            int[] testScores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                Console.Write("Enter test score {0}: ", (i + 1));
                testScores[i] = int.Parse(Console.ReadLine());
            }

            Student s = new Student(firstName, lastName, id, testScores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate());

            Console.ReadLine();
        }
    }
}
