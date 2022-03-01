using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [XmlType("ServiceProto")]
    public enum ServiceProto
    {
        [XmlEnum("rpc")]
        Rpc,
    }
}
