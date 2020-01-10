using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class ElementSettings
    {
        //[XmlElement(ElementName="FontSpec")] public FontSpec FontSpec { get; set; }
        [XmlElement(ElementName="ParagraphSpec")] public ParagraphSpec ParagraphSpec { get; set; }
        //[XmlElement(ElementName="Behavior")] public Behavior Behavior { get; set; }
        [XmlAttribute("Type")]
        public string Type { get; set; }
    }
}