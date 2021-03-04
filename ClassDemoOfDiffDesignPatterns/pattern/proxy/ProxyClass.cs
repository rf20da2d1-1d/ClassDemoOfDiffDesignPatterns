using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoOfDiffDesignPatterns.pattern.proxy
{
    class ProxyClass:IDemoProxy
    {
        private IDemoProxy _realProxy;
        private string _courseName;

        public ProxyClass(string name)
        {
            _realProxy = new RealProxy();
            _courseName = name;
        }

        public void InsertString(string name)
        {
            _realProxy.InsertString($"{name} teach in {_courseName}");
        }

        public List<string> GetAll()
        {
            return _realProxy.GetAll();
        }
    }
}
