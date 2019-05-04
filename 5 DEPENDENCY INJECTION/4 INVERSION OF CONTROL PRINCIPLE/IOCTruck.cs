using System;

namespace IOC
{
    public class Truck
    {
         public void BuildingTruck()
        {
  
            System.Console.WriteLine("this is a truck");
        }
    }
    public class Volvo
    {
        Truck t;

        public Volvo()
        {
            t  = Factory6.GetTruck();
        }

        public void BuildingTruck()
        {
            t.BuildingTruck();
        }
    }

    public class Factory6
    {
        public static Truck GetTruck()
        {
            return new Truck();
        }
    }

    
}