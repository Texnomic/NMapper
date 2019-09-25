using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("port", AnonymousType = true)]
    [XmlRoot("port")]
    public class Port
    {

        [XmlElement("state")]
        public State State { get; set; }

        [XmlElement("owner")]
        public Owner Owner { get; set; }

        [XmlElement("service")]
        public Service Service { get; set; }

        [XmlElement("script")]
        [field: XmlIgnore()]
        public Collection<Script> Script { get; private set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Script-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Script collection is empty.</para>
        /// </summary>
        
        [NotMapped()]
        public bool ScriptSpecified => (Script.Count != 0);

        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Port" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Port" /> class.</para>
        /// </summary>
        public Port()
        {
            Script = new Collection<Script>();
        }

        [XmlAttribute("protocol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PortProtocol Protocol { get; set; }

        [XmlAttribute("portid", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Key()]
        public string Portid { get; set; }
    }
}