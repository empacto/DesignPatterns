using System;

namespace DI2
{

    //interface
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
        
    }

    //customer data access

    public class CustomerDataAccess:ICustomerDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "dummy customer name " + id;
        }

    }

    //customer data access factory

    public class Factory
    {
        public static ICustomerDataAccess GetCusomterDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    //buisness login

    public class BusinessLogic
    {
        ICustomerDataAccess cd;

        public BusinessLogic()
        {
            cd = Factory.GetCusomterDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
          return  cd.GetCustomerName(id);
        }


    }
    
}