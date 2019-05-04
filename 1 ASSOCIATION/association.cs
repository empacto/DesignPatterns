using System;


//https://medium.com/@ibrahimyengue/association-aggregation-and-composition-in-c-8cbeaa81201d

namespace assoc
{

    public class Manager
    {
        private string name;

        public Manager ()
        {
            
        }

           public Manager (string name)
        {
            this.name = name;
            
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public void Logon(SwipeCard sc)
        {
           sc.Swipe(this);
        }


    }


    public class SwipeCard
    {
        private string madeOfCard; 

        public SwipeCard()
        {
            
        }

        public SwipeCard(string madeOfCard)
        {
            this.madeOfCard = madeOfCard;
            
        }

        public string MadeOfCard
        {
            get
            {
                return madeOfCard;
            }
        }

        public void Swipe(Manager manager)
        {
            System.Console.WriteLine("swiping the manager");
        }
    }

}