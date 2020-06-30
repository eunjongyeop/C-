using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Class_IsAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Dog("멍멍이");
            Mammal m2 = new Cat("야옹이");

            (m1 as Dog).Bark();
            if(m2 is Cat)
            {
                ((Cat)m2).Meow();
            }

            Mammal m3 = new Dog("댕댕이");
            Mammal m4 = new Cat("고양이");

            m3.WashMammal();
            m4.WashMammal();
        }
    }

    class Mammal
    {
        protected string name;

        public Mammal(string name)
        {
            this.name = name;
            Console.WriteLine($"생성자 호출: {name}.Mammal()");
        }

        public string GetName()
        {
            return name;
        }

        public void WashMammal()
        {
            Console.WriteLine($"{name}가 씻는다.");
        }
    }

    class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
            Console.WriteLine($"생성자 호출: {name}.Dog()");
        }

        public void Bark()
        {
            Console.WriteLine($"{name}가 멍멍 짖는다.");
        }
    }

    class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
            Console.WriteLine($"생성자 호출: {name}.Cat()");
        }

        public void Meow()
        {
            Console.WriteLine($"{name}가 야옹야옹 운다.");
        }
    }
}
