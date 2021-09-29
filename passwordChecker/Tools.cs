using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    class Tools
    {
        public static void ContainsTest()
        {
            string loudWord = "LASDAD";
            string quietWord = "pssst";
            string mixedWord = "lkaAWEkasfkEW";

            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Running \"tests...\"");
            Console.WriteLine($"Should be true: {Contains(loudWord, uppercase)}");
            Console.WriteLine($"Should be false: {Contains(loudWord, lowercase)}");
            Console.WriteLine($"Should be false: {Contains(quietWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(quietWord, lowercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, uppercase)}");
            Console.WriteLine($"Should be true: {Contains(mixedWord, lowercase)}");
        }

        internal static bool Contains(string password, string uppercase)
        {
            throw new NotImplementedException();
        }
    }
}
