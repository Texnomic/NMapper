using System.Collections.Generic;
using System.Xml.Serialization;
using Texnomic.NMap.Schema.Enums;
using Texnomic.NMap.Schema.Models;

namespace Texnomic.NMap.Schema
{
    [XmlType("nmaprun", AnonymousType = true)]
    [XmlRoot("nmaprun")]
    public class NMapResult
    {
        [XmlElement("scaninfo")]
        public List<ScanInfo> ScanInfo { get; set; } 

        [XmlElement("verbose")]
        public Verbose Verbose { get; set; }

        [XmlElement("debugging")]
        public Debugging Debugging { get; set; }

        [XmlElement("target")]
        public List<Target> Target { get; set; }

        [XmlElement("taskbegin")]
        public List<Taskbegin> TaskBegin { get; set; }

        [XmlElement("taskprogress")]
        public List<Taskprogress> TaskProgress { get; set; }

        [XmlElement("taskend")]
        public List<Taskend> TaskEnd { get; set; }

        [XmlElement("prescript")]
        public List<Prescript> Prescript { get; set; }

        [XmlElement("postscript")] 
        public List<Postscript> Postscript { get; set; }

        [XmlElement("host")] 
        public List<Host> Hosts { get; set; }

        [XmlElement("output")] 
        public List<Output> Output { get; set; }

        [XmlElement("runstats")] 
        public RunStatistics RunStatistics { get; set; }

        [XmlAttribute("scanner")]
        public string Scanner { get; set; }

        [XmlAttribute("args")]
        public string Args { get; set; }

        [XmlAttribute("start")]
        public string Start { get; set; }

        [XmlAttribute("startstr")]
        public string StartString { get; set; }

        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlAttribute("profile_name")]
        public string ProfileName { get; set; }

        [XmlAttribute("xmloutputversion")]
        public string XmlOutputVersion { get; set; }
    }
}
