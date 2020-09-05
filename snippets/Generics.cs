/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Generics
{
    public class Generic<T>
    {
        public T Field;
    }
    public class GenericSample
    {
        public static void Main()
        {
            Generic<string> g = new Generic<string>();
            g.Field = "A string";
            //...
            System.Console.WriteLine("Generic.Field           = \"{0}\"", g.Field);
            System.Console.WriteLine("Generic.Field.GetType() = {0}", g.Field.GetType().FullName);
        }
    }
}
