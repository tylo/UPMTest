using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class CastList
    {
        [XmlElement("CustomOrder")] public string CustomOrder { get; set; }
        [XmlAttribute("SortOption")] public string SortOption { get; set; }
    }
}