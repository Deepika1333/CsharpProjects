using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Networkfile networkObj = new Networkfile();
            networkObj.ReadNetworkDetails();
            Console.ReadKey();
        }
    }
}
