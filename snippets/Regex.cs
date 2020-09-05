/*
 * Copyright (c) 2020 Markus Neifer. All rights reserved.
 */
namespace MnCons.Samples.Regex
{
	using System;
	using System.Text.RegularExpressions;
    internal class Hello
    {
        private static void Sample1() {
			string s = "Uw bestelnummer is: BASE-NL-S-00000218.";
            Regex rx = new Regex(": (?<no>.+)\\.");
			MatchCollection matches = rx.Matches(s);
			Console.WriteLine("{0} ({1} matches):", s, matches.Count);
			foreach (Match match in matches)
			{
				Console.WriteLine("   " + match.Value);
				GroupCollection groups = match.Groups;
				Console.WriteLine("Group match: '{0}'",  groups["no"].Value);
			}
			s = "Ihre Bestell # ist: BASE-DE-S-4800003613.";
            rx = new Regex(": (?<no>.+)\\.");
			matches = rx.Matches(s);
			Console.WriteLine("{0} ({1} matches):", s, matches.Count);
			foreach (Match match in matches)
			{
				Console.WriteLine("   " + match.Value);
				GroupCollection groups = match.Groups;
				Console.WriteLine("Group match: '{0}'",  groups["no"].Value);
			}
		}
        private static void Sample2() {
			string s = "Uw bestelnummer is: BASE-NL-S-00000218.";
			string match = new Regex(": (?<no>.+)\\.").Match(s).Groups["no"].Value;
			Console.WriteLine("Sample2 / Group match: '{0}'",  match);
		}
        private static void Main() {
		    //Sample1();
		    Sample2();
		}
    }
}
