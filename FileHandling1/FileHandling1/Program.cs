using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling1
{
    class Program
    {
        static void Main()
        {
            HospitalFile hospitalFileObj = new HospitalFile();
            //hospitalFileObj.CreateHospital();
            hospitalFileObj.ReadHospitalDetails();
            Console.ReadKey();
        }
    }
}
