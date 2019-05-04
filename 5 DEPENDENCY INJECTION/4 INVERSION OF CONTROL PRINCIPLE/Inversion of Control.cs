using System;

namespace IOC
{

 public class MainClass
 {
     DependendClass d;

     public MainClass()
     {
         d = Factory.GetObjectOfB();
        
     }

     public void Method1()
     {
        d.DoSomething();
     }

 }

 public class DependendClass
 {
     public  void DoSomething()
     {
         System.Console.WriteLine("something is happening in the dependend class");
     }

 }

 public class Factory
 {

     public static DependendClass GetObjectOfB()
     {
         return new DependendClass();
     }

 }

}