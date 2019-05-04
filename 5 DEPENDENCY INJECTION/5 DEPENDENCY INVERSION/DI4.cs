using System;
namespace DI4
{
    //Interface
    public interface IDataAccess
    {
         string GetCustomer(int id);
        
    }

    //dataAccess

    public class DataAccess:IDataAccess
    {
        public string GetCustomer(int id)
        {
            return "customer name " + id; 
        }
    }

    //factory

    public class Factory
    {
        public static IDataAccess GetCustomerDataObj()
        {
            return new DataAccess();
        }
    }

    //Business Logic

    public class BusinessLogic
    {
        IDataAccess _di;

        public BusinessLogic()
        {
            _di = Factory.GetCustomerDataObj();
        }

        public string GetCustomer(int id)
        {

            return _di.GetCustomer(id);

        }

    }
}