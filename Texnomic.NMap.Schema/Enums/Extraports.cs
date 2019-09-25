using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("extraports", AnonymousType = true)]
    [XmlRoot("extraports")]
    public class Extraports
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("extrareasons")]
        
        public Collection<Extrareasons> Extrareasons { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Extrareasons-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Extrareasons collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool ExtrareasonsSpecified => (Extrareasons.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Extraports" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Extraports" /> class.</para>
        /// </summary>
        public Extraports()
        {
            Extrareasons = new Collection<Extrareasons>();
        }

        [XmlAttribute("state", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string State { get; set; }

        [XmlAttribute("count", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Count { get; set; }
    }
}