/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Destructors
{
    class A
    {
        ~A()
        {
            System.Console.WriteLine("Destruct instance of A");
        }
    }
    class B
    {
        object Ref;
    
        public B(object o)
        {
            Ref = o;
        }
    
        ~B()
        {
            System.Console.WriteLine("Destruct instance of B");
        }
    }
    class Test
    {
        static void Main()
        {
            B b = new B(new A());
            b = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
    }
}
