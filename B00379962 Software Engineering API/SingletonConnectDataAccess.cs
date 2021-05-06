using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

