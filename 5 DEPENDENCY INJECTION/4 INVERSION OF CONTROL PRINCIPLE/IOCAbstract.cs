using System;
namespace IOC
{
    public class A
    {
        public void DoSomething()
        {

            System.Console.WriteLine("Class A does something");
        }

    }

    public class B
    {
        A a;

        public B()
        {
            a = Factor8.GetA();

        }

        public void DoSomething()
        {
            a.DoSomething();
        }
    }

    public class Factor8
    {

        public static A GetA()
        {
            return new A();
        }
    }

}