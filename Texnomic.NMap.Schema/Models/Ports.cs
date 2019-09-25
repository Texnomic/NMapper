using System.Collections.Generic;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("ports", AnonymousType = true)]
    [XmlRoot("ports")]
    public class Ports
    {
        [XmlElement("extraports")] 
        public List<Extraports> ExtraPorts { get; set; }

        [XmlElement("port")]
        public List<Port> Port { get; set; }
    }
}