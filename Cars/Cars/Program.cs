using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsAssemble a = new CarsAssemble();
            Console.WriteLine(a.productionRatePerHour(6));
            Console.WriteLine(a.workingItemsPerMinute(6));
            Console.WriteLine(a.SuccessRate(10));
            Console.ReadLine();
        }
    }
}
