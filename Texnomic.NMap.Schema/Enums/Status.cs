using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("status", AnonymousType = true)]
    [XmlRoot("status")]
    public class Status
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public StatusState State { get; set; }

        [XmlAttribute("reason", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reason { get; set; }

        [XmlAttribute("reason_ttl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Reason_Ttl { get; set; }
    }
}