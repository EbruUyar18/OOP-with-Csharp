using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static int myMethod(int x)
        {
            return x * 2; 
        }
        static float myMethod(float x)
        {
            return x + 3;
        }
        static double myMethod(double x)
        {
            return x / 2;
        }
        static void Main(string[] args)
        {
            //YÖNTEM AŞIRI YÜKLEME (method overloading) nedir?
            // birden fazla metot, farklı parametrelere sahip, aynı adda olabilir.
            Console.WriteLine(myMethod(4));
            Console.WriteLine(myMethod(6.0));
            Console.WriteLine(myMethod(7.0f));
            myMethod(5);

        }
    }
}
