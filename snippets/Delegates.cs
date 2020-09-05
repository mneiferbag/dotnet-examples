/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Delegates
{
    // Declare a delegate.
    delegate void Del(string str);
    
    class Hello
    {
        // Declare a method with the same signature as the delegate.
        static void Notify(string name)
        {
            System.Console.WriteLine("Notification received for: {0}", name);
        }
        static void Main() {
            // C# 1.0: Create an instance of the delegate.
            Del del1 = new Del(Notify);
    
            // C# 2.0 provides a simpler way to declare an instance of Del.
            Del del2 = Notify;
    
            // C# 2.0: Instantiate Del by using an anonymous method.
            Del del3 = delegate(string name)
                { System.Console.WriteLine("Notification received for: {0}", name); };
    
            // C# 3.0: Instantiate Del by using a lambda expression.
            Del del4 = name =>  { System.Console.WriteLine("Notification received for: {0}", name); };
    
            del4("Bjarne");
        }
    }
    delegate double Function(double x);
    
    class Multiplier
    {
        double factor;
    
        public Multiplier(double factor) {
            this.factor = factor;
        }
        public double Multiply(double x) {
            return x * factor;
        }
    }
    
    class Test
    {
        static double Square(double x) {
            return x * x;
        }
        static double[] Apply(double[] a, Function f) {
            var result = new double[a.Length];
            for (var i = 0; i < a.Length; i++) result[i] = f(a[i]);
            return result;
        }
        static void Main() {
            var a = new[] {0.0, 0.5, 1.0};
    
            double[] squares = Apply(a, Square);
    
            double[] sines = Apply(a, System.Math.Sin);
    
            Multiplier m = new Multiplier(2.0);
            double[] doubles = Apply(a, m.Multiply);
    
            double[] dbles = Apply(a, (double x) => x * 2.0);
        }
    }
}
