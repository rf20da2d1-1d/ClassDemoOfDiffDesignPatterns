using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.abstractFactory
{
    class AbstractFactory
    {
        public static IFactory GetFactory(AbstractFactoryType typeOfFactory)
        {
            switch (typeOfFactory)
            {
                case AbstractFactoryType.Dk: return new FactoryDK();
                case AbstractFactoryType.Uk: return new FactoryUK();

            }

            return new FactoryUK();
        }
    }
}
