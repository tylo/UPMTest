using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Member
    {
        //[XmlAttribute("Actor")] public string Actor { get; set; }
        [XmlAttribute("Character")] public string Character { get; set; }
    }
}