
/// 01.Program to divide two numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    class Program
    {
        static int Divide(int N1, int N2)
        {
            return N1 / N2; 
        }

        static void Main(string[] args)
        {
            int iValue1 = 15, iValue2 = 5,iRet = 0;

            iRet = Divide(iValue1, iValue2);

            Console.WriteLine("\n\t------------------ Output ------------------\n");
            Console.WriteLine("\n\t\tDivision Of " + iValue1 + " & " + iValue2 + " = " + iRet);
            

            Console.ReadKey();
        }
    }
}
