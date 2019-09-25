using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("portused", AnonymousType = true)]
    [XmlRoot("portused")]
    public class Portused
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string State { get; set; }

        [XmlAttribute("proto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PortusedProto Proto { get; set; }

        [XmlAttribute("portid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Portid { get; set; }
    }
}