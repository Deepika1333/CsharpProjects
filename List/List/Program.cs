using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("abc");
            li.Add("cdaef");
            li.Add("js");
            li.Add("php");

            foreach (var i in li)
                Console.WriteLine(i.Replace("a"," "));
                Console.ReadLine();
        }
    }
}
