using System; 
using System.Reflection;

namespace IOC
{
    public class LivingSpace
    {
        public void SetLivingRoom()
        {
            System.Console.WriteLine("this is a living room " + MethodBase.GetCurrentMethod().Name);
        }
    }

    public class House
    {
        LivingSpace l;

        public House()
        {
            l =  Factory3.GetLivingSpaceObject();
        }

        public void GetLiningSpace()
        {
            l.SetLivingRoom();
        }
    }

    public class Factory3
    {
        public static LivingSpace GetLivingSpaceObject()
        {
            return new LivingSpace();

        }
    }
}