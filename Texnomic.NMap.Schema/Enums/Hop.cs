using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("hop", AnonymousType = true)]
    [XmlRoot("hop")]
    public class Hop
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("ttl", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ttl { get; set; }

        [XmlAttribute("rtt", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Rtt { get; set; }

        [XmlAttribute("ipaddr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ipaddr { get; set; }

        [XmlAttribute("host", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Host { get; set; }
    }
}