using System;

namespace DI
{
    //interface
    public interface ICustomerData
    {
        string GetCustomerName(int i);
        
    }

    //customerData: interface
    public class CustomerData:ICustomerData
    {
        public string GetCustomerName(int id)
        {
            return "This is the customer";
        }
    }

    //factory 
    public class Factory
    {
        public static ICustomerData GetCustomerData()
        {
            return new CustomerData();
        }
    }
    //business Logic 

    public class BusinessLogic
    {
        ICustomerData cd;

        public BusinessLogic()
        {
            cd = Factory.GetCustomerData();
        }

        public string GetCustomerName(int id)
        {
          return cd.GetCustomerName(id);
        }
    }
}