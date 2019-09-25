using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("ServiceMethod")]
    public enum ServiceMethod
    {

        [XmlEnum("table")]
        Table,

        [XmlEnum("probed")]
        Probed,
    }
}