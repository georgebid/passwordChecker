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
