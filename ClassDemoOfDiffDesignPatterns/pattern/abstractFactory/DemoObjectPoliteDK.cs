using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class DemoObjectPoliteDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Kære {name}");
        }
    }
}
