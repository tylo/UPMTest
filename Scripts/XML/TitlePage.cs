using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class TitlePage
    {
        [XmlElement("HeaderAndFooter")] public HeaderAndFooter HeaderAndFooter { get; set; }
        [XmlElement("Content")] public Content Content { get; set; }
    }
}