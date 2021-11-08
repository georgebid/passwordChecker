using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    public interface IRule
    {
        int EvaluateScore(string password);
    }
}


/* start with the letter I - good practice

Homework:

- research collections - ahead of next lesson
- finish adding all the new MustHaveRule instances inside PasswordScorerGuy
- interfaces can contain properties and method, not fields

Learn/revise how to write a:
- New method
- writing a new class
- creating an object/ intance of a class ( MustHaveRule uppercaseRule = new MustHaveRule();

*/
