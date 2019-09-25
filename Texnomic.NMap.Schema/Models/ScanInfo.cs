using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("scaninfo", AnonymousType = true)]
    [XmlRoot("scaninfo")]
    public class ScanInfo
    {
        [XmlAttribute("type")]
        public ScanInfoType Type { get; set; }

        [XmlAttribute("scanflags")]
        public string ScanFlags { get; set; }

        [XmlAttribute("protocol")]
        public Protocol Protocol { get; set; }

        [XmlAttribute("numservices")]
        public int ServiceCount { get; set; }

        [XmlAttribute("services")]
        public string Services { get; set; }
    }
}