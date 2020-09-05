/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Strings
{
    class MyString
    {
       static void Main()
       {
          var msgId = 7;
          
          System.Console.WriteLine(msgId.ToString("D" + 4));
    
          object oa = "hello";
          object ob = "hello";
    
          System.Console.WriteLine(oa == ob);
    
          string sa = "hello";
          string sb = "hello";
    
          System.Console.WriteLine(sa == sb);
       }
    }
}
