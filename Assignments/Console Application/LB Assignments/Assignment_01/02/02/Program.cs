
/// 02. Program to print 5 times “Marvellous” on screen. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    class Program
    {
        static void Display()
        {
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\n\t\tMarvellous");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\n\t------------ Output ------------");
            Display();
           

            Console.ReadKey();
        }
    }
}

