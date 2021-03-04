using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.proxy
{
    interface IDemoProxy
    {
        void InsertString(String str);
        List<String> GetAll();
    }
}
