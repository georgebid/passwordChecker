using System;
using System.Collections.Generic;
using System.Text;

namespace passwordChecker
{
    interface ICantContainRule
    {
        bool EvaluateScore(string password);
    }
}
