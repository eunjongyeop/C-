using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Class_AccessModifiler
{
    class A
    {
        public int value1 = 10;
        protected int value2 = 20;
        private int value3 = 30;

        public class C : A
        {
            public int GetValue3()
            {
                return value3;
            }
        }
    }

    class B : A
    {
        public int GetValue1()
        {
            return value1;
        }

        public int GetValue2()
        {
            return value2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            System.Console.WriteLine($"a.value1 : {a.value1}");
            //System.Console.WriteLine($"a.value2 : {a.value2}");

            B b = new B();
            System.Console.WriteLine($"b.value1 : {b.GetValue1()}");
            System.Console.WriteLine($"b.value2 : {b.GetValue2()}");

            var c = new A.C();
            System.Console.WriteLine($"c.value3 : {c.GetValue3()}");
        }
    }
}
