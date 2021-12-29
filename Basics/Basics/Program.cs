using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"before: a = {a}, b = {b};";
            int temp;

            temp = b;
            b = a;
            a = temp;
            string after = $"After: a = {a}, b = {b}";
            return before + after;

        }
        public static void Main()
        {
            Console.WriteLine(SwapTwoNumbers(87, 45));
            Console.WriteLine(SwapTwoNumbers(-13, 2));
            Console.ReadLine();
        }
    }
}
