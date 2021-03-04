using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.decorator
{
    class ConcreteComponent : IComponent
    {
        public String DoSomething(string str)
        {
            // do nothing just return

            return str;
        }
    }
}
