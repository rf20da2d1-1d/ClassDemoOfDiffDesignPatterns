using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class DemoObjectFriendly:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
