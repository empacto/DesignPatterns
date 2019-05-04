using System;

//inversion of control using factory method !!!

namespace IOC12
{

    public class A
    {
        public void DoSomething()
        {
            System.Console.WriteLine("calls A does something");
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
            _a.DoSomething();
            
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