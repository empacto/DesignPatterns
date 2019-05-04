using System;

namespace IOC
{
    public class Vehicle
    {
        public void Drive2()
        {
           System.Console.WriteLine("the vehicle is drivnng");
           
        }
    }
    public class Car
    {
        Vehicle v;

        public Car()
        {
            v = Factory2.GetObjectOfVehicle();
        }

        public void Drive()
        {
          System.Console.WriteLine("works");
            v.Drive2();
        }
        
    }

    public class Factory2
    {

        public  static Vehicle GetObjectOfVehicle()
        {
            return new Vehicle();
        }

    }


}