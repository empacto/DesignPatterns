using System;

namespace MultiPathInheritance
{

public class Uncle
{
    public Uncle()
    {
        System.Console.WriteLine(" uncle genes activated");
        
    }
}
public class NephewA:Uncle
{
    public NephewA()
    {
        System.Console.WriteLine("genes nephe A activated");
        
    }
}
public class NephewB:Uncle
{
    public NephewB()
    {
        System.Console.WriteLine("genes nephe B activated");
        
    }
}

// public class Child:Uncle,NephewA,NephewB
// {

// }
}

