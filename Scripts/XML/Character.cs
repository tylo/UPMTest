using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Character
    {
        [XmlAttribute("Color")] public string Color { get; set; }
        [XmlAttribute("Name")] public string Name { get; set; }
        [XmlAttribute("Visible")] public string Visible { get; set; }
    }
}