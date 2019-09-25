using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("AddressAddrtype")]
    public enum AddressAddrtype
    {

        [XmlEnum("ipv4")]
        Ipv4,

        [XmlEnum("ipv6")]
        Ipv6,

        [XmlEnum("mac")]
        Mac,
    }
}