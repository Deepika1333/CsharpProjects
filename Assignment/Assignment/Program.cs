﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Networkfile NetworkObj = new Networkfile();
            NetworkObj.ReadNetworkDetails();
            Console.ReadKey();
        }
    }
}
