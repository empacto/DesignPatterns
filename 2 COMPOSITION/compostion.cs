using System;

namespace composition
{

    public class FirstClass
    {

    public string Name { get; set; }

    public void FirstMethod()
    {
        System.Console.WriteLine("this is the first method");
    }  

    public void SecondMethod()
    {
        System.Console.WriteLine("this is the second method");
    }
    }

    public class SecondClass
    {
        private FirstClass _firstClass { get; set; }

        public void SecondMethod()
        {
            _firstClass.FirstMethod();
            _firstClass.SecondMethod(); //must be implemented if not runtime error
        }
    }

}