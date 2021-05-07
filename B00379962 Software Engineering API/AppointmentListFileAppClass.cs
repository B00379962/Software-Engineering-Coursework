using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataAccessManager
{
    public class AppClass
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("time")]
        public int Time { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }

        [XmlArray("Appointments"), XmlArrayItem("Appointment")]
        public List<Appointment> Appointments { get; set; }

    }
}