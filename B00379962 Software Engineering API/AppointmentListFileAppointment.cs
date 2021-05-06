using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DataAccessManager
{
    public class Appointment
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("barberid")]
        public int BarberID { get; set; }

        [XmlAttribute("barber")]
        public string barber { get; set; }

        [XmlAttribute("booked")]
        public string booked { get; set; }

        [XmlAttribute("shop")]
        public string shop { get; set; }
    }
}