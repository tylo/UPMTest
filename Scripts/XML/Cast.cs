using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Cast
    {
        //[XmlElement("Narrator")] public Narrator Narrator { get; set; }
        [XmlElement("Member")] public List<Member> Member { get; set; }
    }
}