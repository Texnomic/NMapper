using System.Collections.Generic;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("osmatch", AnonymousType = true)]
    [XmlRoot("osmatch")]
    public class OperatingSystemMatch
    {
        [XmlElement("osclass")]
        public List<OperatingSystemClass> Class { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("accuracy")]
        public string Accuracy { get; set; }

        [XmlAttribute("line")]
        public string Line { get; set; }
    }
}