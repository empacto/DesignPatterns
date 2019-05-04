using System;

namespace MultipleInheritance
{

 public class GrandFather{
     public GrandFather()
     {
         System.Console.WriteLine("these are the genes of the grandfather");
         
     }
 }
 public class Father:GrandFather
 {
     public Father()
     {
         System.Console.WriteLine("these are the genes of the father");
         
     }
     
 }

 public class Child:Father
 {
     public Child ()
     {
         System.Console.WriteLine("these are the child genes");
         
     }
 }


}