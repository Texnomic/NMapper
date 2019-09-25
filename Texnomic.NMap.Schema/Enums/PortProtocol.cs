using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("PortProtocol")]
    public enum PortProtocol
    {

        [XmlEnum("ip")]
        Ip,

        [XmlEnum("tcp")]
        Tcp,

        [XmlEnum("udp")]
        Udp,

        [XmlEnum("sctp")]
        Sctp,
    }
}