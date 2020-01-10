using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class ParagraphSpec
    {
        [XmlAttribute("Alignment")] public string Alignment { get; set; }
        [XmlAttribute("FirstIndent")] public float FirstIndent { get; set; }
        [XmlAttribute("Leading")] public string Leading { get; set; }
        [XmlAttribute("LeftIndent")] public float LeftIndent { get; set; }
        [XmlAttribute("RightIndent")] public float RightIndent { get; set; }
        [XmlAttribute("SpaceBefore")] public float SpaceBefore { get; set; }
        [XmlAttribute("Spacing")] public float Spacing { get; set; }
        [XmlAttribute("StartsNewPage")] public string StartsNewPage { get; set; }
    }
}