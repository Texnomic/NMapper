using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("hostscript", AnonymousType = true)]
    [XmlRoot("hostscript")]
    public class Hostscript
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("script")]
        [field: XmlIgnore()]
        public Collection<Script> Script { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Hostscript" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Hostscript" /> class.</para>
        /// </summary>
        public Hostscript()
        {
            Script = new Collection<Script>();
        }
    }
}