using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("service", AnonymousType = true)]
    [XmlRoot("service")]
    public class Service
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="Service" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="Service" /> class.</para>
        /// </summary>
        public Service()
        {
            Cpe = new Collection<string>();
        }

        [XmlAttribute("name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Name { get; set; }

        [XmlAttribute("conf", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceConf Conf { get; set; }

        [XmlAttribute("method", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceMethod Method { get; set; }

        [XmlAttribute("version", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Version { get; set; }

        [XmlAttribute("product", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Product { get; set; }

        [XmlAttribute("extrainfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Extrainfo { get; set; }

        [XmlAttribute("tunnel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceTunnel Tunnel { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Tunnel-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Tunnel property is specified.</para>
        /// </summary>
        
        public bool TunnelSpecified { get; set; }

        [XmlAttribute("proto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ServiceProto Proto { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Proto-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Proto property is specified.</para>
        /// </summary>
        
        public bool ProtoSpecified { get; set; }

        [XmlAttribute("rpcnum", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Rpcnum { get; set; }

        [XmlAttribute("lowver", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Lowver { get; set; }

        [XmlAttribute("highver", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Highver { get; set; }

        [XmlAttribute("hostname", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Hostname { get; set; }

        [XmlAttribute("ostype", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Ostype { get; set; }

        [XmlAttribute("devicetype", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Devicetype { get; set; }

        [XmlAttribute("servicefp", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Servicefp { get; set; }
    }
}