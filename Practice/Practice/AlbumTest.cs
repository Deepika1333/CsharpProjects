using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practice
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(27);
            al.Add(65);

            foreach (object obj in al)
            {
                Console.Write(obj + " ");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
