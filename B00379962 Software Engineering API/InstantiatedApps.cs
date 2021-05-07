namespace DataAccessManager
{
    public class InstantiatedApps
    {
        // appointment id
        private int _id;
        // barber id
        private int _barberID;
        // barber name
        private string _barber;
        // booked or not
        private string _booked;
        // shop the booking is for
        private string _shop;
        // generic name for appointment
        private string _name;
        // time of appointment
        private int _time;
        // price of appointment
        private decimal _price;


        public InstantiatedApps(int id, int barberID, string barber, string booked, string shop, string name, int time, decimal price)
        {
            this._id = id;
            this._barberID = barberID;
            this._barber = barber;
            this._booked = booked;
            this._shop = shop;
            this._name = name;
            this._time = time;
            this._price = price;
        }



        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int BarberID
        {
            get { return _barberID; }
            set { _barberID = value; }
        }

        public string Barber
        {
            get { return _barber; }
            set { _barber = value; }

        }

        public string Booked
        {
            get { return _booked; }
            set { _booked = value; }
        }

        public string Shop
        {
            get { return _shop; }
            set { _shop = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
