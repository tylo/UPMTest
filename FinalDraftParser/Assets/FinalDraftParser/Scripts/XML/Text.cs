using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Text
    {
        [XmlAttribute("AdornmentStyle")] public string AdornmentStyle { get; set; }
        [XmlAttribute("Background")] public string Background { get; set; }
        [XmlAttribute("Color")] public string Color { get; set; }
        [XmlAttribute("Font")] public string Font { get; set; }
        [XmlAttribute("RevisionID")] public string RevisionID { get; set; }
        [XmlAttribute("Size")] public string Size { get; set; }
        [XmlAttribute("Style")] public string Style { get; set; }
        [XmlText] public string Text_ { get; set; }
    }
}