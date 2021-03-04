using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class DemoObjectFriendlyDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hej {name}");
        }
    }
}
