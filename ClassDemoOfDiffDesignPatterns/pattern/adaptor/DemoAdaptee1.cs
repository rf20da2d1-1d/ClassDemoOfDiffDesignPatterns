using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.adaptor
{
    class DemoAdaptee1
    {
        public string KindOfPerson(string str)
        {
            if (str == "peter") return "teacher";

            return "student";
        }
    }
}
