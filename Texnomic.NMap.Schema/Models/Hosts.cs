using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("hosts", AnonymousType = true)]
    [XmlRoot("hosts")]
    public class Hosts
    {
        [XmlAttribute("up")]
        public int Up { get; set; }

        [XmlAttribute("down")]
        public int Down { get; set; }

        [XmlAttribute("total")]
        public int Total { get; set; }
    }
}