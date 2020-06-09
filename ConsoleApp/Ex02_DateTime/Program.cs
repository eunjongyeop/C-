using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 12)
            {
                Console.WriteLine("현재 오후 " + hour + "시 입니다.");
            }
            else
            {
                Console.WriteLine("현재 오전 " + hour + "시 입니다.");
            }
        }
    }
}
