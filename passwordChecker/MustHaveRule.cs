using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    public class MustHaveRule : IRule
    {
        //array - []
       //character is anything, including symbols, letters and numbers.
       // array is like a list. 
        private char[] _character;
        // Constructor of the class - create an instance of a class when called.
        // when this constructor is called, it will create an instance do whatever is in the body of the method.
        public MustHaveRule(string characters)
        {
            //research ToCharArray - array- collection of characters. 
            _character = characters.ToCharArray();
        }

        // a method of the MustHaveRule class which takes a string
        public int EvaluateScore(string password)
        {
            //IndexOfAny checks password contains _character 
            bool isInCharacters = password.IndexOfAny(_character) != -1;

            if (isInCharacters) return 1;

            else return 0;

            // return password.IndexOfAny(_character) == -1 ? 0 : 1;

            // make another rule that checks the length - by taking a , implementing the IRule interface




        }
    }
}
