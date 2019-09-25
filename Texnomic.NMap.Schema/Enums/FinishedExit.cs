using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("FinishedExit")]
    public enum FinishedExit
    {

        [XmlEnum("error")]
        Error,

        [XmlEnum("success")]
        Success,
    }
}