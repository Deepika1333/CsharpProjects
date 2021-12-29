using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment
{
    class Networkfile
    {
        public void ReadNetworkDetails()
        {
            FileStream filestreamObj = new FileStream("C:\\Users\\Deepu\\source\\repos\\Assignment1\\Network status.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filestreamObj);
  
                int i;
             int[] Id = new int[12];
             int[] Source = new int[1];
             int[] Destination = new int[1];
             string[] Date = new string[1];
             string[] Status = new string[12];
                string[] Network = new string[11];
            Console.Write("Enter number of Id: ", Id);
            int numId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of source: ", Source);
            int source = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of destination: ", Destination);
            int destination = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= 12; i++)
                {
                    Console.WriteLine("Enter id {0}: ", Id);
                Id[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter status {0}: ", Status);
                Status[i] = Console.ReadLine();
                    Console.WriteLine("Enter network {0}: ", Network);
                Network[i] = Console.ReadLine();
                }

            Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\tStatus\t\tNetwork");
            while (sr.Peek()>0)
            {
                string readMyLine = sr.ReadLine();
                string[] strings = readMyLine.Split(':');
                if (readMyLine != "")
                {
                    if (strings.Length > 1)
                    {
                        if (readMyLine.StartsWith("Date"))
                        {
                            string date = strings[1].Split(' ')[0];
                        }
                        Console.Write(strings[1]+"\t\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }


        
    }
}
