using System;

namespace composition
{

    public class ThirdClass
    {
        public void ThirdMethod()
        {
            System.Console.WriteLine("this is the third method using composition");
        }

    }

    public class FourthClass
    {
        public ThirdClass _thirdClass { get; set; }

        public void FourthMethod()
        {
            _thirdClass.ThirdMethod();
        }

    }
}