using System;
using System.Collections.Generic;
using System.Text;
using static passwordChecker.Rule;

namespace passwordChecker
{
    internal class PasswordScorerGuy
    {
        private readonly int _minLength = 8;
        private readonly string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string _digits = "1234567890";
        private readonly string _specialChar = "~!@#%^&*-+";
        private readonly string _invalidPassword = "password";
        private readonly string _veryWeak = "1234";

        public int ScorePassword(string password)

        {
            // could use password.length >= Rule.minLength

            // the users password is rated using a scoring system. All passwords start at 0 and if they meet requirements the score will increase by 1. 
            int score = 0;
            // if the length of the password is greater than or equal to 8 then increase the score by 1.
            if (password.Length >= _minLength)
            {
                score++;
            }
            // if the password contains a uppercase letter increase the score by 1.

            // type - class, name of the instance, = new(creates a new instance), the name of the class, passing the uppercase variable.
            // all of the below are new instances of the MustHaveRule
            MustHaveRule uppercaseRule = new MustHaveRule(_uppercase);
                score += uppercaseRule.EvaluateScore(password);

            MustHaveRule lowercaseRule = new MustHaveRule(_lowercase);
                score += lowercaseRule.EvaluateScore(password);

            MustHaveRule digitsRule = new MustHaveRule(_digits);
                score += digitsRule.EvaluateScore(password);

            MustHaveRule specialCharRule = new MustHaveRule(_specialChar);
                score += specialCharRule.EvaluateScore(password);
            
            // the below are instaces of the MustEqualRule
            MustEqualRule invalidRule = new MustEqualRule(_invalidPassword);

            //  if the password is equal to 1234 (veryWeak), defined above - the score will be 0.
            MustEqualRule weakRule = new MustEqualRule(_veryWeak);
                score = !weakRule.EvaluateScore(password) && !invalidRule.EvaluateScore(password) ? score++ : 0;

            return score;
       
        }
        public static bool Contains(string target, string list)
        {
            var charArray = list.ToCharArray();
            return target.IndexOfAny(charArray) != -1;
        }
    }
}
