using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling1
{
    class HospitalFile
    {
      public void CreateHospital()
        {
            FileStream fileStreamObj = new FileStream("C:\\Users\\Deepu\\source\\repos\\FileHandling1\\FileHandling1\\HospitalFile", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fileStreamObj);
            sw.WriteLine("Welcome to my hopital");

            Console.Write("Enter hospital name: ");
            string hospitalname = Console.ReadLine();

            Console.Write("Enter hospital address: ");
            string address = Console.ReadLine();
            Console.Write("Enter hospital phone: ");
            int phone = Convert.ToInt32(Console.ReadLine());

            sw.WriteLine("Hospital name:" + hospitalname);
            sw.WriteLine("Hospital address:" + address);
            sw.WriteLine("Phone:" + phone);
            sw.Close();
            fileStreamObj.Close();
            Console.WriteLine("Hospital details saved successfully in the file");
        }
        public void ReadHospitalDetails()
        {
            FileStream filestreamObj = new FileStream("C:\\Users\\Deepu\\source\\repos\\FileHandling1\\FileHandling1\\HospitalFile", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
            while (sr.Peek()>0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                Console.WriteLine(strings[1]);
            }

        }
    }
}

