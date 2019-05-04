using System;

namespace IOC
{
    public class Crane
    {
        public void Lift()
        {
            System.Console.WriteLine("lifting :" + this.GetType().Name);
        }
    }
    public class Container
    {
        Crane c;

        public Container()
        {
            c = Factory7.GetCrane();
        }

        public void Lift()
        {
            c.Lift();
        }

        
    }

    public class Factory7
    {
        public static Crane GetCrane()
        {
            return new Crane();
        }
    }
}