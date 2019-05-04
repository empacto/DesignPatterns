using System;

namespace IOC
{
    public class Furniture
    {

        public void GetMaterial()
        {
            System.Console.WriteLine("this is wood");
        }

    }

    public class BookShelf
    {
        Furniture f ;

        public BookShelf()
        { 
              f = Factory5.GetFurniture();
          
        }

        public void GetMaterial()
        {
            f.GetMaterial() ;
        }



    }

    public class Factory5
    {

        public static Furniture GetFurniture()
        {
            return new Furniture();
        }

    }
}