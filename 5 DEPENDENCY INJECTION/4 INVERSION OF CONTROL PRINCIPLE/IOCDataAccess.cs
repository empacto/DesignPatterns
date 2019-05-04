using System;

namespace IOC
{
    public class DataAccess
    {
        public string GetCustomer()
        {
            return "Dummy customer name"; // get name from database
        }
    }
    public class CustomerLogic
    {
        DataAccess da;
        public CustomerLogic()
        {
            da = DataFactory.GetData();
        }

        public void GetCustomer()
        {
           System.Console.WriteLine(da.GetCustomer() + this.GetType().Name);
        }
    }

    public class DataFactory
    {
        public static DataAccess GetData()
        {
            return new DataAccess();
        }
    }

}