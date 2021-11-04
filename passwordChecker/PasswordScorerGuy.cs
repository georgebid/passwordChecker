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
            if (password.Length >= Rule.minLength)
            {
                score++;
            }
            // if the password contains a uppercase letter increase the score by 1.
            if (Contains(password, _uppercase))
            {
                score++;
            }
            // if the password contains a lowercase letter increase the score by 1.
            if (Contains(password, _lowercase))
            {
                score++;
                // if the password contains a digit increase the score by 1.
            }
            if (Contains(password, _digits))
            {
                score++;
                // if the password contains a special character, increase the score by 1.
            }
            if (Contains(password, _specialChar))
            {
                score++;
            }
            //  if the password is equal to the invalid password, defined above - the score will be 0.
            if (password.ToLower().Equals(_invalidPassword))
            {
                score = 0;
            }
            //  if the password is equal to 1234 (veryWeak), defined above - the score will be 0.
            if (password.Equals(_veryWeak))
            {
                score = 0;
            }

            return score;
       
        }
        public static bool Contains(string target, string list)
        {
            var charArray = list.ToCharArray();
            return target.IndexOfAny(charArray) != -1;
        }
    }
}
