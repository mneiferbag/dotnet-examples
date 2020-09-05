/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Inheritance
{
    class MyBase
    {
        public string GetString()
        {
            return "fooBase";
        }
    }
    class MyClass : MyBase
    {
        new public string GetString()
        {
            return "fooClass";
        }
    }
    class A
    {
        public void F() { System.Console.WriteLine("A.F"); }
        public virtual void G() { System.Console.WriteLine("A.G"); }
    }
    class B: A
    {
        new public void F() { System.Console.WriteLine("B.F"); }
        public override void G() { System.Console.WriteLine("B.G"); }
    }
    class Test
    {
        static void Main()
        {
            var c = new MyClass();
            System.Console.WriteLine(c.GetString());
    
            B b = new B();
            A a = b;
            a.F();
            b.F();
            a.G();
            b.G();
        }
    }
}
