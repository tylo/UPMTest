using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Content
    {
        [XmlElement("Paragraph")] public List<Paragraph> Paragraphs { get; set; }
    }
}