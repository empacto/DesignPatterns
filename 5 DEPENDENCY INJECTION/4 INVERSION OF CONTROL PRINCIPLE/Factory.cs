using System;

namespace IOC13
{
    public class A
    {

        public void DoSometing()
        {
            System.Console.WriteLine("class A does something");
        }
    }

    public class B
    {
        A _a; 

        public B()
        {
            _a = Factory.GetAObj();
        }

        public void DoSomething()
        {
            _a.DoSometing();
        }

    }
    public class Factory
    {
        public static A GetAObj()
        {
            return new A();
        }

        
    }
}