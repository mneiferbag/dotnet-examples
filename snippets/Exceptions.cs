/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Exceptions
{
    class MyException : System.ApplicationException
    {
    }
    class Program
    {
        static void Main()
        {
            var program = new Program();
            try
            {
                program.DoThis();
            }
            catch (MyException e)
            {
                System.Console.Write("Exception in DoThis(): ");
                System.Console.WriteLine(e.ToString());
            }
            try
            {
                program.DoThat();
            }
            catch (MyException e)
            {
                System.Console.Write("Exception in DoThat(): ");
                System.Console.WriteLine(e.ToString());
            }
            try
            {
                program.DoIt();
            }
            catch (MyException e)
            {
                System.Console.Write("Exception in DoIt(): ");
                System.Console.WriteLine(e.ToString());
            }
        }
        void DoThis()
        {
            try
            {
                ThrowsException();
            }
            catch (MyException e)
            {
                throw e;
            }
        }
        void DoThat()
        {
            try
            {
                ThrowsException();
            }
            catch (MyException e)
            {
                throw;
            }
        }
        void DoIt()
        {
            ThrowsException();
        }
        void ThrowsException()
        {
            throw new MyException();
        }
    }
}
