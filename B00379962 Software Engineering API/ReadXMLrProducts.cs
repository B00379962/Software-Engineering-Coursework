using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessManager
{
    public class Rproducts : ReadFile
    {

        private List<InstantiatedProducts> _prodList = new List<InstantiatedProducts>();

        public override object Read()
        {
            // This method reads in the products and adds them to Instantiated Products
            ProductListFile readProduct = XmlUtils.ReadXML<ProductListFile>(Environment.CurrentDirectory + @"\products.xml");
            foreach (ProdClass e in readProduct.ProdClasses)
            {
                
                foreach (Product p in e.Products)
                {
                    // add each product to Instantiated Products
                    _prodList.Add(new InstantiatedProducts(p.Name, p.Ammount, p.ProductID));
                }
            }
            
            return _prodList;
        }

        public InstantiatedProducts GetById(int id)
        {
            // used to return one product using the product ID
            return this._prodList.FirstOrDefault(z => z.Prodid == id);
        }
    }
}
