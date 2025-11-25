using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static int intMethod(int x,int y)
        {
            return x * y;
        }
        static double doubleMethod(double x, double y)
        {
            return x +y;
        }

        static void Main(string[] args)
        {
            int myNum = intMethod(4, 6);
            double myDouble = doubleMethod(3.6, 2.4);
            Console.WriteLine(myNum);
            Console.WriteLine(myDouble);

        }
    }
}
