using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.factory
{
    class DemoFactory
    {
        public static IDemoObject GetClass(FactoryType typeOfClass)
        {
            if (typeOfClass == FactoryType.Friendly)
            {
                return new FriendlyVersion();
            }
            else
            {
                return new PoliteVersion();
            }
                

        }
    }
}
