namespace DataAccessManager
{
    public class InstantiatedProducts
    {
        // name of product
        private string _name;
        //amount of product in stock
        private int _amount;
        // id of product
        private int _prodid;

        public InstantiatedProducts(string name, int Amount, int prodid)
        {
            this._name = name;
            this._amount = Amount;
            this._prodid = prodid;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public int Prodid
        {
            get { return _prodid; }
            set { _prodid = value; }

        }
    }
}




