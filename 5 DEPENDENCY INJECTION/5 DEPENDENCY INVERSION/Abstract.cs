using System;

//dependency inversion + fator + abstraction => interface

namespace AbstractDI
{
    public interface IDataAccess
    {
        string GetCustomer();
    }
    public class DataAccess:IDataAccess
    {
        public string GetCustomer()
        {
            return "cusomer name";
        }

    }

    public class Factor
    {
        public static IDataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }

    public class BusinessLogic
    {
        IDataAccess _da; 

        public BusinessLogic()
        {
            _da = Factor.GetDataAccessObj();
        }

        public string GetCustomer()
        {
            return _da.GetCustomer();
        }
    }



}