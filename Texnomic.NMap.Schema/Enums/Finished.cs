using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Texnomic.NMap.Schema.Enums
{
    [GeneratedCode("XmlSchemaClassGenerator", "2.0.0.0")]
    [XmlType("finished", AnonymousType = true)]
    [XmlRoot("finished")]
    public class Finished
    {

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        
        [Key()]
        public long Id { get; set; }

        [XmlAttribute("time", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Time { get; set; }

        [XmlAttribute("timestr", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Timestr { get; set; }

        [XmlAttribute("elapsed", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Elapsed { get; set; }

        [XmlAttribute("summary", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Summary { get; set; }

        [XmlAttribute("exit", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FinishedExit Exit { get; set; }

        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Exit-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Exit property is specified.</para>
        /// </summary>
        
        public bool ExitSpecified { get; set; }

        [XmlAttribute("errormsg", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Errormsg { get; set; }
    }
}