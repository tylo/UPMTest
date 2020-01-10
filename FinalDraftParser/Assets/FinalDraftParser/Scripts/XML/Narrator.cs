using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Narrator
    {
        // [XmlElement("Element")] public List<Element> Element { get; set; }
        [XmlAttribute("Actor")] public string Actor { get; set; }
    }
}