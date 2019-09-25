using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("osclass", AnonymousType = true)]
    [XmlRoot("osclass")]
    public class Osclass
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlElement("cpe")]
        [field: XmlIgnore()]
        public Collection<string> Cpe { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Cpe-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Cpe collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool CpeSpecified => (Cpe.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Osclass" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Osclass" /> class.</para>
        /// </summary>
        public Osclass()
        {
            Cpe = new Collection<string>();
        }

        [XmlAttribute("vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Vendor { get; set; }

        [XmlAttribute("osgen", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Osgen { get; set; }

        [XmlAttribute("type", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Type { get; set; }

        [XmlAttribute("accuracy", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Accuracy { get; set; }

        [XmlAttribute("osfamily", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Osfamily { get; set; }
    }
}