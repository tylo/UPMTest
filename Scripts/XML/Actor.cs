using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Actor
    {
        [XmlAttribute("Name")] public string Name { get; set; }
    }
}