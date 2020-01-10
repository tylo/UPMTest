using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Header
    {
        [XmlElement("Paragraph")] public Paragraph Paragraph { get; set; }
    }
}