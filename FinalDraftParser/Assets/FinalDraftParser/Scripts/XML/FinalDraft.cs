using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class FinalDraft
    {
        [XmlElement("Content")] public Content Content { get; set; }
        //[XmlElement("HeaderAndFooter")] public HeaderAndFooter HeaderAndFooter { get; set; }
        [XmlElement("TitlePage")] public TitlePage TitlePage { get; set; }
        //[XmlElement("Actors")] public Actors Actors { get; set; }
        [XmlElement("Cast")] public Cast Cast { get; set; }
        //[XmlElement("CastList")] public CastList CastList { get; set; }
        [XmlElement(ElementName="ElementSettings")] public List<ElementSettings> ElementSettings { get; set; }
    }
}