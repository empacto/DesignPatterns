using System;

// https://riptutorial.com/csharp/example/30087/adapter-design-pattern

namespace Adapter4
{
  public interface ITarget
{
    void MethodA();
}

public class Adaptee
{
    public void MethodB()
    {
        Console.WriteLine("MethodB() is called");
    }
}

public class Client
{
    private ITarget target;

    public Client(ITarget target)
    {
        this.target = target;
    }

    public void MakeRequest()
    {
        target.MethodA();
    }
}  

public class Adapter : Adaptee, ITarget
{
    public void MethodA()
    {
        MethodB();
    }
}

}