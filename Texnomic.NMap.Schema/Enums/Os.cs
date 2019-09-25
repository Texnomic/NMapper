using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("os", AnonymousType = true)]
    [XmlRoot("os")]
    public class Os
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("portused")]
        [field: XmlIgnore()]
        public Collection<Portused> Portused { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Portused-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Portused collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool PortusedSpecified => (Portused.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Os" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Os" /> class.</para>
        /// </summary>
        public Os()
        {
            Portused = new Collection<Portused>();
            Osmatch = new Collection<Osmatch>();
            Osfingerprint = new Collection<Osfingerprint>();
        }

        [XmlElement("osmatch")]
        [field: XmlIgnore()]
        public Collection<Osmatch> Osmatch { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Osmatch-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Osmatch collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool OsmatchSpecified => (Osmatch.Count != 0);

        [XmlElement("osfingerprint")]
        [field: XmlIgnore()]
        public Collection<Osfingerprint> Osfingerprint { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Osfingerprint-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Osfingerprint collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool OsfingerprintSpecified => (Osfingerprint.Count != 0);
    }
}