using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    class Rule
    {
        // what can the rule class do? Hold static values
        // What does it need to know? the rules for how the password is scored




        private static readonly int minLength = 8;
        private readonly string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string _digits = "1234567890";
        private readonly string _specialChar = "~!@#%^&*-+";
        private readonly string _invalidPassword = "password";
        private readonly string _veryWeak = "1234";
    }
}
