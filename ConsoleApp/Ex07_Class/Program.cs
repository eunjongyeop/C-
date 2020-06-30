using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Class
{
    class Cube
    {
        private int x, y, z;
        public static int countOfInstance;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            countOfInstance++;
        }

        public int GetVoume()
        {
            return x*y*z;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cube cube1 = new Cube(1, 2, 3);
            System.Console.WriteLine($"생성된 Cube의 개수 : {Cube.countOfInstance}");
            System.Console.WriteLine($"cube1의 부피 : {cube1.GetVoume()}");
            System.Console.WriteLine();

            Cube cube2 = new Cube(3, 4, 5);
            System.Console.WriteLine($"생성된 Cube의 개수 : {Cube.countOfInstance}");
            System.Console.WriteLine($"cube의 부피 : {cube2.GetVoume()}");
        }
    }
}
