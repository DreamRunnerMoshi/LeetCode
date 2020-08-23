using Algorithms;
using LeetCode.Solutions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ProgramClient
{

    class A
    {

    }

    class B : A
    {

    }

    class C : A
    {

    }

    class D : B
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            PrintType(new B());
            PrintType(new C());
            PrintType(new D());
        }

        static void PrintType(A a)
        {
            Console.WriteLine(a.GetType().Name);
        }
    }
}
