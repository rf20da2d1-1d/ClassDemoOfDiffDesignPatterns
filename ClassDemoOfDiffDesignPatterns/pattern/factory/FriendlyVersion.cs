using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.factory
{
    class FriendlyVersion:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
