using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataAccessManager
{

    [XmlRoot("AppClasses")]
    public class AppointmentListFile
    {
        [XmlElement("AppClass")]
        public List<AppClass> AppClasses { get; set; }
    }
}