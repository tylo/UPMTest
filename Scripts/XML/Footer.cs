using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Footer
    {
        [XmlElement("Paragraph")] public Paragraph Paragraph { get; set; }
    }
}