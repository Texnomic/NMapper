using System.Collections.Generic;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("service", AnonymousType = true)]
    [XmlRoot("service")]
    public class Service
    {
        [XmlElement("cpe")]
        public List<string> CPE { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("conf")]
        public ServiceConf Conf { get; set; }

        [XmlAttribute("method")]
        public ServiceMethod Method { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("product")]
        public string Product { get; set; }

        [XmlAttribute("extrainfo")]
        public string ExtraInfo { get; set; }

        [XmlAttribute("tunnel")]
        public ServiceTunnel Tunnel { get; set; }

        [XmlAttribute("proto")]
        public ServiceProto Proto { get; set; }
        
        [XmlAttribute("rpcnum")]
        public string Rpcnum { get; set; }

        [XmlAttribute("lowver")]
        public string LowVersion { get; set; }

        [XmlAttribute("highver")]
        public string HighVersion { get; set; }

        [XmlAttribute("hostname")]
        public string HostName { get; set; }

        [XmlAttribute("ostype")]
        public string OperatingSystemType { get; set; }

        [XmlAttribute("devicetype")]
        public string DeviceType { get; set; }

        [XmlAttribute("servicefp")]
        public string ServiceFP { get; set; }
    }
}