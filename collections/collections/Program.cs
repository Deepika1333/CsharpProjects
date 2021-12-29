using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections
{
    public class Program
    {
        public void ToString()
        {
            Queue names = new Queue();
            names.Enqueue("deepika");
            names.Enqueue("chikku");
            names.Enqueue("ajith");

            Queue age = new Queue();
            age.Enqueue(21);
            age.Enqueue(1);
            age.Enqueue(30);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names.Dequeue() + "-" + age.Dequeue());

            }
        }
        class Person
        {
            static void Main(String[] args)
            {
                Program p = new Program();
                p.ToString();
                Console.ReadLine();
            }
        }
      

    }
}
