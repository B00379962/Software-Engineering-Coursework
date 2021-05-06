using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccessManager
{
    [XmlRoot("ProdClasses")]
    public class ProductListFile
    {
        [XmlElement("ProdClass")]
        public List<ProdClass> ProdClasses { get; set; }
    }
}
