using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.factory
{
    class PoliteVersion:IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine("Dear " + name);
        }
    }
}
