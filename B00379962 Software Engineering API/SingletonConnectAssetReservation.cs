using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetReservation
{
    public sealed class SingletonAssetReservation
    {
        private static volatile SingletonAssetReservation _instance;
        private static readonly object _lock = new object();

        private SingletonAssetReservation()
        {
            Console.WriteLine("You are connected to Asset Reservation");
        }

        public static SingletonAssetReservation Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonAssetReservation();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
