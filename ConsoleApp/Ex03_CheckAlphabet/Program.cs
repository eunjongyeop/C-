using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_CheckAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character : ");
            char c = (char)Console.Read();

            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                Console.WriteLine(c + "는 알파벳 입니다.");
            }
            else
            {
                Console.WriteLine(c + "는 알파벳이 아닙니다.");
            }
        }
    }
}
