using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class DemoObjectPolite:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Dear {name}");
        }
    }
}
