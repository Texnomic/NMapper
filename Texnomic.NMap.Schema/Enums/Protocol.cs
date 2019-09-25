using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("ScaninfoProtocol")]
    public enum Protocol
    {

        [XmlEnum("ip")]
        IP,

        [XmlEnum("tcp")]
        TCP,

        [XmlEnum("udp")]
        UDP,

        [XmlEnum("sctp")]
        SCTP,

        [XmlEnum("rpc")] 
        RPC,
    }
}