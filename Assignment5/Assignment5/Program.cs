using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new ProductionRemoteControlCar();
            TestTrack.Race(prod);
            var exp = new ExperimentalRemoteControlCar();
            TestTrack.Race(exp);
            Console.ReadKey();
        }
    }
}
