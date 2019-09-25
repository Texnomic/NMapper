using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("StatusState")]
    public enum StatusState
    {

        [XmlEnum("up")]
        Up,

        [XmlEnum("down")]
        Down,

        [XmlEnum("unknown")]
        Unknown,

        [XmlEnum("skipped")]
        Skipped,
    }
}