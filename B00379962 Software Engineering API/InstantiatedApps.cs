using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class InstantiatedApps
    {
        private int id;
        private int barberID;
        private string barber;
        private string booked;
        private string shop;
        private string name;
        private int time;
        private decimal price;


        public InstantiatedApps(int id, int barberID, string barber, string booked, string shop, string name, int time, decimal price)
        {
            this.id = id;
            this.barberID = barberID;
            this.barber = barber;
            this.booked = booked;
            this.shop = shop;
            this.name = name;
            this.time = time;
            this.price = price;
        }



        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int BarberID
        {
            get { return barberID; }
            set { barberID = value; }
        }

        public string Barber
        {
            get { return barber; }
            set { barber = value; }

        }

        public string Booked
        {
            get { return booked; }
            set { booked = value; }
        }

        public string Shop
        {
            get { return shop; }
            set { shop = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
