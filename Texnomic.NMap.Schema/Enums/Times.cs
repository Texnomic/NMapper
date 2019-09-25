using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("times", AnonymousType = true)]
    [XmlRoot("times")]
    public class Times
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("srtt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Srtt { get; set; }

        [XmlAttribute("rttvar", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Rttvar { get; set; }

        [XmlAttribute("to", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string To { get; set; }
    }
}