using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class FactoryDK:IFactory
    {
        public IDemoObject GetClass(FactoryType typeOfClass)
        {
            switch (typeOfClass)
            {
                case FactoryType.Friendly: return new DemoObjectFriendlyDK();
                case FactoryType.Polite: return new DemoObjectPoliteDK();
            }

            return new DemoObjectPoliteDK();
        }
    }
}
