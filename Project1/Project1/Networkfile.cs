using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    class Networkfile
    {
        public void CreateNetwork()
        {
            FileStream fileStreamObj = new FileStream("C:\\Users\\Deepu\\source\\repos\\Project1\\Project1\\Networkfile", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fileStreamObj);
            sw.WriteLine("checking network");

            Console.Write("id: ");
            string id = Console.ReadLine();

            Console.Write("source: ");
            string source = Console.ReadLine();

            Console.Write("destination: ");
            string destination = Console.ReadLine();

            Console.Write("date: ");
            string date = Console.ReadLine();

            Console.Write("status: ");
            string status = Console.ReadLine();

            Console.Write("network: ");
            string network = Console.ReadLine();

            sw.WriteLine("1:" + id);
            sw.WriteLine("86876786:" + source);
            sw.WriteLine("878979723:" + destination);
            sw.WriteLine("9/12/2021:" + date);
            sw.WriteLine("failed:" + status);
            sw.WriteLine("jio:" + network);
            sw.Close();
            fileStreamObj.Close();
            Console.WriteLine("network details saved successfully in the file");
        }
        public void ReadNetworkDetails()
        {
            FileStream fileStreamObj = new FileStream("C:\\Users\\Deepu\\source\\repos\\Project1\\Project1\\Networkfile", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fileStreamObj);
            while (sr.Peek() > 0)
            {
                string readmyline = sr.ReadLine();
                string[] strings = readmyline.Split(':');
                if (strings.Length > 1)
                    Console.WriteLine(strings[1]);
            }
        }
    }
}
