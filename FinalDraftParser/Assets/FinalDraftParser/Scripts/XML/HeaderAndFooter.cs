using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class HeaderAndFooter
    {
        [XmlElement("Header")] public Header Header { get; set; }
        [XmlElement("Footer")] public Footer Footer { get; set; }
        [XmlAttribute("FooterFirstPage")] public string FooterFirstPage { get; set; }
        [XmlAttribute("FooterVisible")] public string FooterVisible { get; set; }
        [XmlAttribute("HeaderFirstPage")] public string HeaderFirstPage { get; set; }
        [XmlAttribute("HeaderVisible")] public string HeaderVisible { get; set; }
        [XmlAttribute("StartingPage")] public string StartingPage { get; set; }
    }
}