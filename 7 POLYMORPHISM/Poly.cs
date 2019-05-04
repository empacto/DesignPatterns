using System;


namespace poly
{
    /// <summary>
    /// COMPILE TIME METHOD POLYMORPHISM
    /// </summary>
      public class Calculate

{

 

  
    public void AddNumbers(int a, int b)

    {

        Console.WriteLine("a + b = {0}", a + b);

    }

    public void AddNumbers(int a, int b, int c)

    {

        Console.WriteLine("a + b + c = {0}", a + b + c);

    }

    }

public class BClass
{
    public virtual void Test()
    {
        System.Console.WriteLine("this is the base class");
    }


}

public class DClass:BClass
{
    public override void Test()
    {
        System.Console.WriteLine("this is the derived class");
    }
}

}