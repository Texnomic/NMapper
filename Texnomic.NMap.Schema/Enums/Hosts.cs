using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("hosts", AnonymousType = true)]
    [XmlRoot("hosts")]
    public class Hosts
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [System.ComponentModel.DefaultValueAttribute("0")]
        [XmlAttribute("up", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [field: XmlIgnore()]
        public string Up { get; set; } = "0";

        [System.ComponentModel.DefaultValueAttribute("0")]
        [XmlAttribute("down", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [field: XmlIgnore()]
        public string Down { get; set; } = "0";

        [XmlAttribute("total", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Total { get; set; }
    }
}