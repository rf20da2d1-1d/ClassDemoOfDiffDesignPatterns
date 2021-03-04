using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Schema;
using ClassDemoOfDiffDesignPatterns.pattern.abstractFactory;
using ClassDemoOfDiffDesignPatterns.pattern.adaptor;
using ClassDemoOfDiffDesignPatterns.pattern.decorator;
using ClassDemoOfDiffDesignPatterns.pattern.factory;
using ClassDemoOfDiffDesignPatterns.pattern.observer;
using ClassDemoOfDiffDesignPatterns.pattern.proxy;
using ClassDemoOfDiffDesignPatterns.pattern.singleton;
using ClassDemoOfDiffDesignPatterns.pattern.strategy;
using FactoryType = ClassDemoOfDiffDesignPatterns.pattern.factory.FactoryType;
using IComponent = ClassDemoOfDiffDesignPatterns.pattern.decorator.IComponent;
using IDemoObject = ClassDemoOfDiffDesignPatterns.pattern.factory.IDemoObject;

namespace ClassDemoOfDiffDesignPatterns
{
    class PatternWorker
    {
        public void Start()
        {
            /*
             * Creation Pattern
             */
            //DemoSingleton();

            //DemoFactoryMethod();
            
            //DemoAbstractFactory();

            /*
             * Structural pattern
             */
            //DemoAdaptor();

            //DemoProxy();

            DemoDecorator();

            /*
             * Behaviour Pattern
             */
            //DemoObserver();

            //DemoTemplate();

            //DemoStrategy();
        }

        
        private void DemoSingleton()
        {
            NoteCatalogue c1 = NoteCatalogue.Instance;
            c1.Add("New note");
            Console.WriteLine(c1);

            NoteCatalogue c2 = NoteCatalogue.Instance;
            c2.Add("yet another note");
            Console.WriteLine(c2);
        }

        private void DemoFactoryMethod()
        {
            IDemoObject obj = DemoFactory.GetClass(FactoryType.Polite);
            obj.Print("Peter");

            IDemoObject obj2 = DemoFactory.GetClass(FactoryType.Friendly);
            obj2.Print("Peter");

        }

        private void DemoAbstractFactory()
        {
            IFactory factory = AbstractFactory.GetFactory(AbstractFactoryType.Uk);
            pattern.abstractFactory.IDemoObject obj = factory.GetClass(pattern.abstractFactory.FactoryType.Polite);
            obj.Print("Peter");

            IFactory factory2 = AbstractFactory.GetFactory(AbstractFactoryType.Dk);
            pattern.abstractFactory.IDemoObject obj2 = factory2.GetClass(pattern.abstractFactory.FactoryType.Friendly);
            obj2.Print("Peter");

        }

        private void DemoAdaptor()
        {
            IAdaptor adap = new Adaptor1();
            string newstr = adap.Request("peter");
            Console.WriteLine(newstr);

            IAdaptor adap2 = new Adaptor2();
            string newstr2 = adap2.Request("anders");
            Console.WriteLine(newstr2);

        }

        private void DemoProxy()
        {
            IDemoProxy proxy = new RealProxy();

            proxy.InsertString("Peter");
            proxy.InsertString("Anders");
            proxy.InsertString("Vibeke");
            proxy.InsertString("Michael C");

            foreach (string s in proxy.GetAll())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("    AFTER PROXY ");
            IDemoProxy proxy2 = new ProxyClass("SWC");

            proxy2.InsertString("Peter");
            proxy2.InsertString("Anders");

            foreach (string s in proxy2.GetAll())
            {
                Console.WriteLine(s);
            }

        }

        private void DemoDecorator()
        {
            // Concrete
            IComponent component = new ConcreteComponent();
            Console.WriteLine(component.DoSomething("peter"));

            IComponent comp2 = new Decorator1(component);
            Console.WriteLine(comp2.DoSomething("peter"));

            IComponent comp3 = new Decorator1(comp2);
            Console.WriteLine(comp3.DoSomething("peter"));

        }


        private void DemoObserver()
        {
            // I am observer
            ObservableObject obj = new ObservableObject(3, "text");
            obj.Text = "Peter"; // nothing happen


            // attach to be observer
            obj.PropertyChanged += (s, args) =>
            {
                Console.WriteLine($"Anonym metode :the changed property is {args.PropertyName}");
                Console.WriteLine($"New values is \n{s}");
            };

            // alternative
            obj.PropertyChanged += Update;

            obj.Text = "Anders";

            obj.PropertyChanged -= Update;

            obj.Text = "Vibeke";


        }

        /*
         * Help to Observer
         */
        protected void Update(object obj, PropertyChangedEventArgs args)
        {
            Console.WriteLine($" Egentlig metode : the changed property is {args.PropertyName}");
            Console.WriteLine($"New values is \n{obj}");
        }



        private void DemoTemplate()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            //AbstractTemplateClass temp = new MySubTemplate();
            //temp.InsertTemplateMethod(data);

            //Console.WriteLine(temp);

        }

        private void DemoStrategy()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            
            ContextClassMoreCSharpLike context2 = new ContextClassMoreCSharpLike();
            context2.StrategyMethod = (s) => { return s.Substring(1); };
            context2.InsertStrategyMethod(data);
            Console.WriteLine(context2);

        }
    }
}