using System;

namespace DI5
{
    //interface
    public interface IDataAcess
    {
        string GetCustomer(int id);
        
    }

    //dataccess:interface
    public class DataAccess:IDataAcess
    {
        public string GetCustomer(int id)
        {
            return " customer name " + id;
        }
    }

    //factory
    public class Factory
    {
        public static IDataAcess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }

    //businesslogic

    public class BusinessLogic
    {
        IDataAcess _da;
        public BusinessLogic()
        {
            _da = Factory.GetDataAccessObj();
        }

        public string GetCustomer(int id)
        {
            return  _da.GetCustomer(id);
        } 
    }
}