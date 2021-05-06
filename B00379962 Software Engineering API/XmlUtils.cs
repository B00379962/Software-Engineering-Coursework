using System;
using System.Xml.Serialization;
using System.IO;

namespace DataAccessManager
{
    public static class XmlUtils
    {
        public static T ReadXML<T>(string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    var xsz = new XmlSerializer(typeof(T));
                    // Return the deserialized the XML
                    return (T)xsz.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return default;
        }

        public static bool WriteXML<T>(T classToSave, string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    var xsz = new XmlSerializer(typeof(T));
                    // Serialized the XML
                    xsz.Serialize(stream, classToSave);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

    }
}