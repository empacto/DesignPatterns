using System;

namespace GOF
{
    public class Singleton2
    {
        private static Singleton2 _instance;
        private static Object _lock = new Object();

        private Singleton2()
        {         
        }

        public static Singleton2 GetInstance()
        {
            lock(_lock)
            {
                return _instance??(_instance = new Singleton2());

            }
        }
    }
}