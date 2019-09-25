using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("script", AnonymousType = true)]
    [XmlRoot("script")]
    public class Script
    {

        [XmlAttribute("id", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Key()]
        public string Id { get; set; }

        [XmlAttribute("output", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Output { get; set; }
    }
}