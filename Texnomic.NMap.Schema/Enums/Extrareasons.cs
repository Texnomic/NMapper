using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("extrareasons", AnonymousType = true)]
    [XmlRoot("extrareasons")]
    public class Extrareasons
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("reason", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reason { get; set; }

        [XmlAttribute("count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Count { get; set; }
    }
}