using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("target", AnonymousType = true)]
    [XmlRoot("target")]
    public class Target
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("specification", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Specification { get; set; }

        [XmlAttribute("status", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TargetStatus Status { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Status-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Status property is specified.</para>
        /// </summary>
        
        public bool StatusSpecified { get; set; }

        [XmlAttribute("reason", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TargetReason Reason { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Reason-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Reason property is specified.</para>
        /// </summary>
        
        public bool ReasonSpecified { get; set; }
    }
}