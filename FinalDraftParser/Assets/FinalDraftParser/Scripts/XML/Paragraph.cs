using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Paragraph
    {
        // [XmlElement("SceneProperties")] public SceneProperties SceneProperties { get; set; }
        [XmlAttribute("Type")] public string Type { get; set; }
        [XmlElement("Text")] public List<Text> Text { get; set; }
        // [XmlElement("DynamicLabel")] public List<DynamicLabel> DynamicLabel { get; set; }
        // [XmlElement("Tabstops")] public Tabstops Tabstops { get; set; }
        [XmlAttribute("Alignment")] public string Alignment { get; set; }
        [XmlAttribute("FirstIndent")] public string FirstIndent { get; set; }
        [XmlAttribute("Leading")] public string Leading { get; set; }
        [XmlAttribute("LeftIndent")] public string LeftIndent { get; set; }
        [XmlAttribute("RightIndent")] public string RightIndent { get; set; }
        [XmlAttribute("SpaceBefore")] public string SpaceBefore { get; set; }
        [XmlAttribute("Spacing")] public string Spacing { get; set; }
        [XmlAttribute("StartsNewPage")] public string StartsNewPage { get; set; }
    }
}