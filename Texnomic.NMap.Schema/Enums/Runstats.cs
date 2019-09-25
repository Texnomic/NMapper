using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("runstats", AnonymousType = true)]
    [XmlRoot("runstats")]
    public class RunStats
    {

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [Key()]
        public long Id { get; set; }

        [XmlElement("finished")]
        public Finished Finished { get; set; }

        [XmlElement("hosts")]
        public Hosts Hosts { get; set; }
    }
}