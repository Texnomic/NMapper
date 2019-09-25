using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("osmatch", AnonymousType = true)]
    [XmlRoot("osmatch")]
    public class Osmatch
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("osclass")]
        [field: XmlIgnore()]
        public Collection<Osclass> Osclass { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Osclass-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Osclass collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool OsclassSpecified => (Osclass.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Osmatch" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Osmatch" /> class.</para>
        /// </summary>
        public Osmatch()
        {
            Osclass = new Collection<Osclass>();
        }

        [XmlAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlAttribute("accuracy", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Accuracy { get; set; }

        [XmlAttribute("line", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Line { get; set; }
    }
}