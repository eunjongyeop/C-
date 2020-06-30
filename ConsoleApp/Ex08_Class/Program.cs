using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08_Class
{
    class Class1
    {
        public int a, b, c;

        public Class1()
        {
            this.a = 1;
            System.Console.WriteLine("Class1() 호출");
        }

        public Class1(int b) : this()
        {
            this.b = b;
            System.Console.WriteLine($"Class1({b}) 호출");
        }

        public Class1(int b, int c): this(b)
        {
            this.c = c;
            System.Console.WriteLine($"Class1({b}, {c}) 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*****기본 생성자 사용*****");

            Class1 class1 = new Class1();
            System.Console.WriteLine($"a:{class1.a}, b:{class1.b}, c:{class1.c}");
            System.Console.WriteLine();

            Class1 class2 = new Class1(2);
            System.Console.WriteLine($"a:{class2.a}, b:{class2.b}, c:{class2.c}");
            System.Console.WriteLine();

            Class1 class3 = new Class1(2, 3);
            System.Console.WriteLine($"a:{class3.a}, b:{class3.b}, c:{class3.c}");
            System.Console.WriteLine();
        }
    }
}
