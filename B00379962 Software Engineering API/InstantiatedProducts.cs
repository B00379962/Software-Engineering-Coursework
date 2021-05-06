using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class InstantiatedProducts
    {
        private string name;
        private int Amount;
        private int prodid;

        public InstantiatedProducts(string name, int Amount, int prodid)
        {
            this.name = name;
            this.Amount = Amount;
            this.prodid = prodid;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int amount
        {
            get { return Amount; }
            set { Amount = value; }
        }

        public int Prodid
        {
            get { return prodid; }
            set { prodid = value; }

        }
    }
}




