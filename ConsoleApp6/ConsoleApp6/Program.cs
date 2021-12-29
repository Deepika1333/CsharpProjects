using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "hello world ";
            reverseWords(str);
            
        }
        static void reverseWords(string str)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < str.Length; ++i)
            {
                if(str[i] != ' ')
                {
                    st.Push(str[i]);
                }
                else
                {
                    while(st.Count > 0)
                    {
                        Console.Write(st.Pop());
                    }
                    Console.Write(" ");
                }
            }
            while(st.Count > 0)
            {
                Console.Write(st.Pop());
            }

            Console.ReadLine();

        }
    }
}
