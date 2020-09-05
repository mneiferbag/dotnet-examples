/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Decimals
{
    class MyDecimal
    {
        static void Main() {
            double  dbl1 = 1;
            double  dbl2 = 3;
            decimal dec1 = 1;
            decimal dec2 = 3;
            System.Console.WriteLine(dbl1 / dbl2);
            System.Console.WriteLine(dec1 / dec2);
        }
    }
}
