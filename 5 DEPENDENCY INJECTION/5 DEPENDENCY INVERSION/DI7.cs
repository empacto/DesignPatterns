using System;

namespace DI7
{
    //interface
    public interface IDataAccess
    {

        string GetCustomer();
        
    }

    //dataccesss: interface
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

    //business logic

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