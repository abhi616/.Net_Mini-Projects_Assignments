
/// 03. Program to print 5 to 1 numbers on screen.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03
{
    class Program
    {
        static void Display()
        {
            int i = 5;

            for (; i > 0; i--)
            {
                Console.WriteLine("\n\t\t"+i);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n\t-------- Output --------");
            Display();
            
            Console.ReadKey();
        }
    }
}
