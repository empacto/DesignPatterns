using System;

//class with 1 instance

namespace sing7{
public class Singleton
{
    private static Singleton _instance ;
    private static Object _lock = new Object();

    private Singleton(){}

    public static  Singleton GetInstance()
    {
            lock(_lock)
            {
                return _instance??(_instance = new Singleton());
            }

    }
}

public class Client
{
    public Client()
    {
        var s1 = Singleton.GetInstance();
        var s2 = Singleton.GetInstance();

        if(s1 == s2)
        System.Console.WriteLine("works fine");

    }
}


}