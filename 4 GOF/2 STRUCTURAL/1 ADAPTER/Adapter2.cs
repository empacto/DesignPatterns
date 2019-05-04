using System;

namespace GOF2
{
    public interface ITarget
    {
        string GetRequest();
    }

    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "this is a specific Request";
        }
    }
}