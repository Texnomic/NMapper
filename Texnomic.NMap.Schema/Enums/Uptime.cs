using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("uptime", AnonymousType = true)]
    [XmlRoot("uptime")]
    public class Uptime
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("seconds", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Seconds { get; set; }

        [XmlAttribute("lastboot", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lastboot { get; set; }
    }
}