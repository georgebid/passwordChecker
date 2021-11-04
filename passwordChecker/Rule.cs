using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    class Rule
    {
        // what can the rule class do? Hold static values
        // What does it need to know? the rules for how the password is scored

        /* put the criteria for the password in here and call from PasswordScorerGuy. 
        The rule class and properties can be static and used in PasswordScorerGuy (see comment in
        PasswordScorerGuy)
        
        initialising a rule => public Rule rule = new Rule();
        /
       
        - its static because the password will always need to be a minlength of 8,
        - therefore all thats needed is to call it, "just getting a reference/'lookup'" for minlength.
        1 test:
        */
        public static readonly int minLength = 8;



        private readonly string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string _lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string _digits = "1234567890";
        private readonly string _specialChar = "~!@#%^&*-+";
        private readonly string _invalidPassword = "password";
        private readonly string _veryWeak = "1234";
    }
}
