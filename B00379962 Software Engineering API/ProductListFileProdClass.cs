using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessManager
{
    public class ProdClass
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlArray("Products"), XmlArrayItem("Product")]
        public List<Product> Products { get; set; }
    }
}
