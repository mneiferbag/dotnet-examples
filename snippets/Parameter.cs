/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Parameter
{
    using System;

    class Program
    {
        static void Main()
        {
            // Omit the optional parameters.
            Method();

            // Omit second optional parameter.
            Method(4);

            // You can't omit the first but keep the second.
            // Method("Dot");

            // Classic calling syntax.
            Method(4, "Dot");

            // Specify one named parameter.
            Method(name: "Sam");

            // Specify both named parameters.
            Method(value: 5, name: "Allen");
        }
        static void Method(int value = 1, string name = "Perl")
        {
            Console.WriteLine("value = {0}, name = {1}", value, name);
        }
    }
    class OptionalExample
    {
        static void Main(string[] args)
        {
            // Instance anExample does not send an argument for the constructor's
            // optional parameter.
            ExampleClass anExample = new ExampleClass();
            anExample.ExampleMethod(1, "One", 1);
            anExample.ExampleMethod(2, "Two");
            anExample.ExampleMethod(3);

            // Instance anotherExample sends an argument for the constructor's
            // optional parameter.
            ExampleClass anotherExample = new ExampleClass("Provided name");
            anotherExample.ExampleMethod(1, "One", 1);
            anotherExample.ExampleMethod(2, "Two");
            anotherExample.ExampleMethod(3);

            // The following statements produce compiler errors.

            // An argument must be supplied for the first parameter, and it
            // must be an integer.
            //anExample.ExampleMethod("One", 1);
            //anExample.ExampleMethod();

            // You cannot leave a gap in the provided arguments. 
            //anExample.ExampleMethod(3, ,4);
            //anExample.ExampleMethod(3, 4);

            // You can use a named parameter to make the previous 
            // statement work.
            anExample.ExampleMethod(3, optionalint: 4);
        }
    }
    class ExampleClass
    {
        private string _name;

        // Because the parameter for the constructor, name, has a default
        // value assigned to it, it is optional.
        public ExampleClass(string name = "Default name")
        {
            _name = name;
        }
        // The first parameter, required, has no default value assigned
        // to it. Therefore, it is not optional. Both optionalstr and 
        // optionalint have default values assigned to them. They are optional.
        public void ExampleMethod(int required, string optionalstr = "default string",
            int optionalint = 10)
        {
            Console.WriteLine("{0}: {1}, {2}, and {3}.", _name, required, optionalstr,
                optionalint);
        }
    }
}