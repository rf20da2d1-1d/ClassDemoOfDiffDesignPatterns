using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    interface IFactory
    {
        IDemoObject GetClass(FactoryType typeOfClass);
    }
}
