using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class A
    {
        public decimal b;
        public decimal a;
        public decimal c;
        public decimal C
        {
            get
            {
                for (int i = 1; i <= 3; i++)
                {
                    c = a + i + b;
                }
                return c;
            }
            set
            {
                c = value;
            }
        }
        public A(decimal a, decimal b)
        {
            a = 2;
            b = 4;
        }
        public A() { }
    }
    class B : A
    {
        public decimal d;
        public decimal c2;
        public decimal C2
        {
            get
            {
                c2 = a += b - d;
                return c2;
            }
            set
            {
                c2 = value;
            }
        }
        public B()
        {
        }
        public B(decimal a, decimal b, decimal d) : base(a, b)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            obj.a = 7;
            obj.b = 3;
            B obj1 = new B(1, 2, 3);

            obj1.a = obj.a;
            obj1.b = obj.b;
            obj1.d = 1;
            Console.WriteLine("В классе A a={0} b={1} c={2}", obj.a, obj.b, obj.C);
            Console.WriteLine("В классе B a={0} b={1} c2={2} d={3}", obj1.a, obj1.b, obj1.C2, obj1.d);
            Console.ReadKey();
        }
    }
}