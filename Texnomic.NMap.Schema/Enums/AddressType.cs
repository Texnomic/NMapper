using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [XmlType("AddressAddrtype")]
    public enum AddressType
    {

        [XmlEnum("ipv4")]
        IPv4,

        [XmlEnum("ipv6")]
        IPv6,

        [XmlEnum("mac")]
        Mac,
    }
}