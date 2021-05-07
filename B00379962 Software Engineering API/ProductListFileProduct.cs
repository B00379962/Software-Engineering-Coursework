using System.Xml.Serialization;

namespace DataAccessManager
{
    public class Product
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("Amount")]
        public int Ammount { get; set; }

        [XmlAttribute("prodid")]
        public int ProductID { get; set; }
    }
}
