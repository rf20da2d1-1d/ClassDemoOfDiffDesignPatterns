using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.adaptor
{
    class Adaptor1:IAdaptor
    {
        private DemoAdaptee1 adap = new DemoAdaptee1();


        public string Request(string str)
        {
            return adap.KindOfPerson(str);
        }
    }
}
