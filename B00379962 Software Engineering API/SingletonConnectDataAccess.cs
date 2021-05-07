using System;

namespace DataAccessManager
{
    public sealed class SingletonDataAccessManager
    {
        private static volatile SingletonDataAccessManager _instance;
        private static readonly object _lock = new object();

        private SingletonDataAccessManager()
        {
            Console.WriteLine("You are connected to Data Access Manager");
        }

        public static SingletonDataAccessManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonDataAccessManager();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}

