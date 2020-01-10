using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinalDraftParser
{
    public class Actors
    {
        [XmlElement("Actor")] public List<Actor> Actor { get; set; }
    }
}