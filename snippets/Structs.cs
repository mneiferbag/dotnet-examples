/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Structs
{
    internal class StructTest
    {
        internal struct Struct1
        {
            internal string s;
        }
        private static void Main() {
            Struct1 s11;
            s11.s = "foobar";
            Struct1 s12 = s11;
            s12.s = "foobaz";
            Console.WriteLine("s11.s = " + s11.s);
            Console.WriteLine("s12.s = " + s12.s);
        }
    }
}
