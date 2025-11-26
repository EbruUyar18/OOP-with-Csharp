using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static int plusMethod(int a, int b)
        {
            return a * b;
        }
        static double plusMethod(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int myInt = plusMethod(3, 5);
            double myDouble = plusMethod(2.1, 4.9);
            Console.WriteLine("integer:" + myInt);
            Console.WriteLine("double:" + myDouble);
            // parametre sayısı ve/veya türü farklı olduğu sürece birden fazla metot adı aynı olabilir
        }
    }
}
