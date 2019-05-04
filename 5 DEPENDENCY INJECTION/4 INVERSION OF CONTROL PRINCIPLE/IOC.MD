# INVERSION OF CONTROL
IoC is a design principle which recommends inversion of different kinds of controls in object oriented design to achieve loose coupling between the application classes. Here, the control means any additional responsibilities a class has other than its main responsibility, such as control over the flow of an application, control over the dependent object creation and binding (Remember SRP-Single Responsibility Principle). If you want to do TDD (Test Driven Development) then you must use IoC principle without which TDD is not possible. Learn about IoC in detail in the next chapter.

## EXAMPLE:

l. To explain in layman's term, suppose you drive a car to your work place, it means you control the car. IoC principle suggests to invert the control, meaning instead of driving the car yourself, you hire a cab where another person will drive the car. Thus it is called inversion of the control from you to the cab driver. 

## CLASSICAL PATTERN: SUBCLASS IS DEPENDENCY FOR 
Class A depends on class B for its execution: 

class A calls b.SomeMethod() to complete its task1. Class A cannot complete its task without class B and so you can say "Class A is dependent on class B" or "class B is a dependency of class A".

```
public class A
{
    B b;

    public A()
    {
        b = new B();
    }

    public void Task1() {
        // do something here..
        b.SomeMethod();
        // do something here..
    }

}

public class B {

    public void SomeMethod() { 
        //doing something..
    }
}

```
## INVERSION OF CONTROL PRINCIPLE = USE FACTORY TO BREAK DEPENDENCY:
```
public class A
{
    B b;

    public A()
    {
        b = Factory.GetObjectOfB ();
    }

    public void Task1() {
        // do something here..
        b.SomeMethod();
        // do something here..
    }
}

public class B {

    public void SomeMethod() { 
        //doing something..
    }

public class Factory
{
    public static B GetObjectOfB() 
    {
        return new B();
    }
}
```


