using System;
using System.Collections.Generic;
using System.Text;

// if the passwords are equal to invalid or weak passwords, then the score is 0.
namespace passwordChecker
{
    public class MustEqualRule : ICantContainRule
    {
        // this is a class level private variable, it can be used anywhere in this class.
        // undefined
        private string _password;
  
        // public as its a constructor - they are always named the same as the class.
        // MustEqualRule takes a string when calling the constructor assigning _password to character
        public MustEqualRule(string someString)
        {
            // _password now = "password"
            _password = someString;
        }
            // evaluate score takes a string as a parameter called usersPassword
        public bool EvaluateScore(string usersPassword)
        {
            return usersPassword.ToLower().Equals(_password);
        }


        //public void resetRule(string newRule)
       // {
          //  _password = newRule;
      //  }
    }
}
