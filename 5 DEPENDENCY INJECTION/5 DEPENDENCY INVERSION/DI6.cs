using System;

namespace DI6
{
    // interface
    public interface IDataAccess
    {
        string GetCustomer();
        
    }

    // customerData :interface

    public class DataAccess:IDataAccess
    {
        public string GetCustomer()
        {
           return "customer name";
        }
    }

    //factory
    public class Factory
    {
       public static IDataAccess GetDataAccessObj()
       {
           return new DataAccess();
       } 
    }

    //businessLogic
    public class BusinessLogic
    {
        IDataAccess _da;

        public BusinessLogic()
        {
            _da = Factory.GetDataAccessObj();
        }
        public string GetCustomer()
        {
            return _da.GetCustomer();
        }
    }

}