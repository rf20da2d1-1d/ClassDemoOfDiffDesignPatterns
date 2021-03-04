using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.adaptor
{
    class Adaptor2:IAdaptor
    {
        private DemoAdaptee2 adap = new DemoAdaptee2();


        public string Request(string str)
        {
            return adap.Upper(str);
        }
    }
}
