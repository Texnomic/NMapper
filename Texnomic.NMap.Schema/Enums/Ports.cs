using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("ports", AnonymousType = true)]
    [XmlRoot("ports")]
    public class Ports
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("extraports")]
        [field: XmlIgnore()]
        public Collection<Extraports> Extraports { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Extraports-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Extraports collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool ExtraportsSpecified => (Extraports.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Ports" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Ports" /> class.</para>
        /// </summary>
        public Ports()
        {
            Extraports = new Collection<Extraports>();
            Port = new Collection<Port>();
        }

        [XmlElement("port")]
        [field: XmlIgnore()]
        public Collection<Port> Port { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Port-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Port collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool PortSpecified => (Port.Count != 0);
    }
}