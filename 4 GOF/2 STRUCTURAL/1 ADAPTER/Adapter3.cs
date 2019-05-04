using System;

namespace Adap3
{
    public interface ITarget
    {
        string GetRequest();
    }

    public class Adaptee
    {
        public string GetInfo()
        {
            return "getting info from a strange object";
        }
    }

    public class Adapter:ITarget
    {

        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;

        }

        public string GetRequest()
        {
            return $"this is a {this._adaptee.GetInfo()}";
        }
    }
}