using System;

namespace IOC
{
    public class Chair
    {
        public void GetForm()
        {
            System.Console.WriteLine("this is a chair form");
        }
    }

    public class ArmChair
    {
        Chair c ;

        public ArmChair()
        {
          c =  Factory4.GetChairObject();
        }
        public void GetArmChairForm()
        {
          c.GetForm();
        }
    }

    public class Factory4
    {
        public static Chair GetChairObject()
        {
            return new Chair();
        }
    }
}