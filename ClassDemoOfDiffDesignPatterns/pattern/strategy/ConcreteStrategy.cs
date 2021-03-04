using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.strategy
{
    class ConcreteStrategy:IStrategy
    {
        public string MakeString(string s)
        {
            return s.ToUpper();
        }
    }
}
