using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("host", AnonymousType = true)]
    [XmlRoot("host")]
    public class Host
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("status")]
        public Status Status { get; set; }

        [XmlElement("address")]
        public Address Address { get; set; }

        [XmlElement("hostnames")]
        [field: XmlIgnore()]
        public Collection<Hostnames> Hostnames { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Hostnames-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Hostnames collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool HostnamesSpecified => (Hostnames.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Host" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Host" /> class.</para>
        /// </summary>
        public Host()
        {
            Hostnames = new Collection<Hostnames>();
            Smurf = new Collection<Smurf>();
            Ports = new Collection<Ports>();
            Os = new Collection<Os>();
            Distance = new Collection<Distance>();
            Uptime = new Collection<Uptime>();
            Tcpsequence = new Collection<Tcpsequence>();
            Ipidsequence = new Collection<Ipidsequence>();
            Tcptssequence = new Collection<Tcptssequence>();
            Hostscript = new Collection<Hostscript>();
            Trace = new Collection<Trace>();
        }

        [XmlElement("smurf")]
        [field: XmlIgnore()]
        public Collection<Smurf> Smurf { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Smurf-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Smurf collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool SmurfSpecified => (Smurf.Count != 0);

        [XmlElement("ports")]
        [field: XmlIgnore()]
        public Collection<Ports> Ports { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Ports-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Ports collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool PortsSpecified => (Ports.Count != 0);

        [XmlElement("os")]
        [field: XmlIgnore()]
        public Collection<Os> Os { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Os-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Os collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool OsSpecified => (Os.Count != 0);

        [XmlElement("distance")]
        [field: XmlIgnore()]
        public Collection<Distance> Distance { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Distance-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Distance collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool DistanceSpecified => (Distance.Count != 0);

        [XmlElement("uptime")]
        [field: XmlIgnore()]
        public Collection<Uptime> Uptime { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Uptime-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Uptime collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool UptimeSpecified => (Uptime.Count != 0);

        [XmlElement("tcpsequence")]
        [field: XmlIgnore()]
        public Collection<Tcpsequence> Tcpsequence { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Tcpsequence-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Tcpsequence collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool TcpsequenceSpecified => (Tcpsequence.Count != 0);

        [XmlElement("ipidsequence")]
        [field: XmlIgnore()]
        public Collection<Ipidsequence> Ipidsequence { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Ipidsequence-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Ipidsequence collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool IpidsequenceSpecified => (Ipidsequence.Count != 0);

        [XmlElement("tcptssequence")]
        [field: XmlIgnore()]
        public Collection<Tcptssequence> Tcptssequence { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Tcptssequence-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Tcptssequence collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool TcptssequenceSpecified => (Tcptssequence.Count != 0);

        [XmlElement("hostscript")]
        [field: XmlIgnore()]
        public Collection<Hostscript> Hostscript { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Hostscript-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Hostscript collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool HostscriptSpecified => (Hostscript.Count != 0);

        [XmlElement("trace")]
        [field: XmlIgnore()]
        public Collection<Trace> Trace { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Trace-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Trace collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool TraceSpecified => (Trace.Count != 0);

        [XmlElement("times")]
        public Times Times { get; set; }

        [XmlAttribute("starttime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Starttime { get; set; }

        [XmlAttribute("endtime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Endtime { get; set; }

        [XmlAttribute("comment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Comment { get; set; }
    }
}