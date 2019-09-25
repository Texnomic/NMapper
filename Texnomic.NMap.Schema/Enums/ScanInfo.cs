using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("scaninfo", AnonymousType = true)]
    [XmlRoot("scaninfo")]
    public class ScanInfo
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ScanInfoType Type { get; set; }

        [XmlAttribute("scanflags", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Scanflags { get; set; }

        [XmlAttribute("protocol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ScanInfoProtocol Protocol { get; set; }

        [XmlAttribute("numservices", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Numservices { get; set; }

        [XmlAttribute("services", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Services { get; set; }
    }
}