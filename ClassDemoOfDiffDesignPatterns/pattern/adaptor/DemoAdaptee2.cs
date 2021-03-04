using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.adaptor
{
    class DemoAdaptee2
    {
        public string Upper(string str)
        {
            return str.ToUpper();
        }
    }
}
