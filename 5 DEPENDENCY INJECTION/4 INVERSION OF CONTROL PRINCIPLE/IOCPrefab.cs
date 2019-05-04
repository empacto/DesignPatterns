using System;

namespace IOC{

public class Prefab
{

    public void Build()
    {
        System.Console.WriteLine("building a house");
    }
}

public class House2
{

    Prefab pf;

  public House2()
  {
      pf= Factor.GetPrefab();
      
  }

  public void build()
  {
      pf.Build();
  }

}

public class Factor
{
    public static Prefab GetPrefab()
    {
        return new Prefab();

    }
}

}