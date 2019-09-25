using System.Collections.Generic;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema.Models
{
    [XmlType("host", AnonymousType = true)]
    [XmlRoot("host")]
    public class Host
    {
        [XmlElement("status")]
        public Status Status { get; set; }

        [XmlElement("address")]
        public Address Address { get; set; }

        [XmlElement("hostnames")]
        public List<Hostname> HostNames { get; set; }

        [XmlElement("smurf")]
        public List<Smurf> Smurf { get; set; }

        [XmlElement("ports")]
        public List<Ports> Ports { get; set; }

        [XmlElement("os")]
        public List<OperatingSystem> OperatingSystems { get; set; }

        [XmlElement("distance")]
        public List<Distance> Distance { get; set; }

        [XmlElement("uptime")]
        public List<Uptime> UpTime { get; set; }

        [XmlElement("tcpsequence")]
        public List<Tcpsequence> TcpSequence { get; set; }

        [XmlElement("ipidsequence")]
        public List<Ipidsequence> IpidSequence { get; set; }

        [XmlElement("tcptssequence")]
        public List<Tcptssequence> TcptsSequence { get; set; }

        [XmlElement("hostscript")]
        public List<Hostscript> HostScript { get; set; }

        [XmlElement("trace")]
        public List<Trace> Trace { get; set; }

        [XmlElement("times")]
        public Times Times { get; set; }

        [XmlAttribute("starttime")]
        public string StartTime { get; set; }

        [XmlAttribute("endtime")]
        public string EndTime { get; set; }

        [XmlAttribute("comment")]
        public string Comment { get; set; }
    }
}