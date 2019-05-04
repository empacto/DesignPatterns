using System; 

//NOT OK NOT THE DESIRED RESULT

namespace  assoc
{
    public class CompanyA
    {
        public int Shares { get; set; }

        public CompanyA(int num)
        {
            this.Shares = num;
            
        }

        public void NumberOfShares(CompanyB b)
        {
            System.Console.WriteLine("company b has " +b.Shares + " in company A");
        }
    }

    public class CompanyB
    {
        public int Shares { get; set; }

        public CompanyB(int num)
        {
            this.Shares = num;
            
        }

        public void NumberOfShares(CompanyA a)
        {
            System.Console.WriteLine("company A has " +a.Shares + " in company B");


        }

    }
}