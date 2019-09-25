using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using Texnomic.NMap.Schema.Enums;

namespace Texnomic.NMap.Schema
{
    [XmlType("nmaprun", AnonymousType = true)]
    [XmlRoot("nmaprun")]
    public class NMapResult
    {
        [KeyAttribute()]
        public long ID { get; set; }

        [XmlElementAttribute("scaninfo")]
        public List<ScanInfo> ScanInfo { get; set; } = new List<ScanInfo>();

        [XmlElementAttribute("verbose")]
        public Verbose Verbose { get; set; } = new Verbose();

        [XmlElementAttribute("debugging")]
        public Debugging Debugging { get; set; } = new Debugging();

        [XmlElementAttribute("target")]
        public List<Target> Target { get; set; } = new List<Target>();

        [XmlElementAttribute("taskbegin")]
        public List<Taskbegin> TaskBegin { get; set; } = new List<Taskbegin>();

        [XmlElementAttribute("taskprogress")]
        public List<Taskprogress> TaskProgress { get; set; } = new List<Taskprogress>();

        [XmlElementAttribute("taskend")]
        public List<Taskend> TaskEnd { get; set; } = new List<Taskend>();

        [XmlElementAttribute("prescript")]
        public List<Prescript> Prescript { get; set; } = new List<Prescript>();

        [XmlElementAttribute("postscript")] 
        public List<Postscript> Postscript { get; set; } = new List<Postscript>();

        [XmlElementAttribute("host")] 
        public List<Host> Hosts { get; set; } = new List<Host>();

        [XmlElementAttribute("output")] 
        public List<Output> Output { get; set; } = new List<Output>();

        [XmlElementAttribute("runstats")] 
        public RunStats RunStats { get; set; } = new RunStats();

        [XmlAttributeAttribute("scanner")]
        public NMapRunScanner Scanner { get; set; }

        [XmlAttributeAttribute("args")]
        public string Args { get; set; }

        [XmlAttributeAttribute("start")]
        public string Start { get; set; }

        [XmlAttributeAttribute("startstr")]
        public string StartString { get; set; }

        [XmlAttributeAttribute("version")]
        public string Version { get; set; }

        [XmlAttributeAttribute("profile_name")]
        public string ProfileName { get; set; }

        [XmlAttributeAttribute("xmloutputversion")]
        public string XmlOutputVersion { get; set; }
    }
}
