using System;
using System.Collections.Generic;
using System.Text;

// if the passwords are equal to invalid or weak passwords, then the score is 0.
namespace passwordChecker
{
    public class MustEqualRule : ICantContainRule
    {
        private string _password;
        
        public MustEqualRule(string characters)
        {
            _password = characters;
        }
            

        public bool EvaluateScore(string password)
        {
            return password.ToLower().Equals(_password);
        }
    }
}
