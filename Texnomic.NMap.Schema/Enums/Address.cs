using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("address", AnonymousType = true)]
    [XmlRoot("address")]
    public class Address
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("addr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Addr { get; set; }

        [System.ComponentModel.DefaultValueAttribute(AddressAddrtype.Ipv4)]
        [XmlAttribute("addrtype", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [field: XmlIgnore()]
        public AddressAddrtype Addrtype { get; set; } = AddressAddrtype.Ipv4;

        [XmlAttribute("vendor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Vendor { get; set; }
    }
}