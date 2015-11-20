using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyResearch
{
    struct Point
    {
        public int X;
        public int Y;


        public void Increment()
        {
            X++;
            Y++;
        }

        public void Decrement()
        {
            X--;
            Y--;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

    }
    class MyClass
    {
        private int _a;
        public int A { get; set; }
        public int B { get; set; }
        public static int C { get; set; }

        static MyClass()
        {
            C = 10;
        }
        public MyClass(int a, int b)
        {
            A = a;
            B = b;

        }


    }
    public class Counter
    {
        public static int currentCount;

        private Counter()
        {
            Console.WriteLine("Private Constructor");
        }
        public static int Increment()
        {
            return ++currentCount;
        }

        private class NestedCalss
        {
            Counter c = new Counter();
        }
    }
    internal class A
    {
        protected int a;

        public A(int aVal)
        {
            a = 20;
        }

        public virtual void Print()
        {
            Console.WriteLine(a);
        }
    }
    class B : A
    {
        private int b;
        public B(int aVal, int bVal)
            : base(aVal)
        {
            a = aVal;
            b = bVal;
        }

        public override void Print()
        {

        }
    }


    public class ReadonlyClass
    {

        public readonly string A = "123";

        public ReadonlyClass(string s)
        {
            A = s;
        }

        public ReadonlyClass()
        {
            A = "345";
        }
    }

    public class ConstClass
    {
        public const string A = "123";

        public ConstClass()
        {
           // A = "344";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
