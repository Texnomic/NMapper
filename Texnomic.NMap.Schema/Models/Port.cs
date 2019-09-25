using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("port", AnonymousType = true)]
    [XmlRoot("port")]
    public class Port
    {
        [XmlAttribute("portid"), Key]
        public string PortID { get; set; }

        [XmlElement("state")]
        public State State { get; set; }

        [XmlElement("owner")]
        public Owner Owner { get; set; }

        [XmlElement("service")]
        public Service Service { get; set; }

        [XmlElement("script")]
        public List<Script> Script { get; set; }

        [XmlAttribute("protocol")]
        public Protocol Protocol { get; set; }
    }
}