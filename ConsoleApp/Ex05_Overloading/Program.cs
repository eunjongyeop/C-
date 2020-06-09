using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plus(1, 2)");
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine("Plus(1.2, 3.4)");
            Console.WriteLine(Plus(1.2, 3.4));
        }

        private static int Plus(int n1, int n2)
        {
            return n1 + n2;
        }

        private static double Plus(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
