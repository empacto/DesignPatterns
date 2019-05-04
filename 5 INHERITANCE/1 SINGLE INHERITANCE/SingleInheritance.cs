using System;

namespace SingleInheritance
{
    public class Father
    {
        public Father()
        {
            System.Console.WriteLine("these are the father genes");
        }
    }

    public class Child: Father
    {
        public Child()
        {
            
        }

    }
}