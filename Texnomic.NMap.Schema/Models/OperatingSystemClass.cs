using System.Collections.Generic;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("osclass", AnonymousType = true)]
    [XmlRoot("osclass")]
    public class OperatingSystemClass
    {
        [XmlElement("cpe")]
        public List<string> CPE { get; set; }

        [XmlAttribute("vendor")]
        public string Vendor { get; set; }

        [XmlAttribute("osgen")]
        public string Generation { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        [XmlAttribute("accuracy")]
        public string Accuracy { get; set; }

        [XmlAttribute("osfamily")]
        public string Family { get; set; }
    }
}