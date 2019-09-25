using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("hostnames", AnonymousType = true)]
    [XmlRoot("hostnames")]
    public class Hostnames
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("hostname")]
        [field: XmlIgnore()]
        public Collection<Hostname> Hostname { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Hostname-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Hostname collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool HostnameSpecified => (Hostname.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Hostnames" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Hostnames" /> class.</para>
        /// </summary>
        public Hostnames()
        {
            Hostname = new Collection<Hostname>();
        }
    }
}