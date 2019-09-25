using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("trace", AnonymousType = true)]
    [XmlRoot("trace")]
    public class Trace
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("hop")]
        [field: XmlIgnore()]
        public Collection<Hop> Hop { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Hop-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Hop collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool HopSpecified => (Hop.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Trace" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Trace" /> class.</para>
        /// </summary>
        public Trace()
        {
            Hop = new Collection<Hop>();
        }

        [XmlAttribute("proto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Proto { get; set; }

        [XmlAttribute("port", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Port { get; set; }
    }
}