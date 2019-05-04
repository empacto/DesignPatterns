using System;


namespace sing5
{
    public class Singleton
    {
        private static Singleton _instance; 

        private static Object _lock = new Object();

        private Singleton(){}

        public static Singleton GetInstance()
        {
            lock(_lock)
            {
                return _instance??(_instance = new Singleton());

            }
        }
    }
}