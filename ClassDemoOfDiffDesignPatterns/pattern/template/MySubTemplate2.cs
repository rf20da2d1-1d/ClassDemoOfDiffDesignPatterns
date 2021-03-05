using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.template
{
    class MySubTemplate2:AbstractTemplateClass
    {
        protected override string MakeString(string s)
        {
            return "anden tekst " + s;
        }
    }
}
