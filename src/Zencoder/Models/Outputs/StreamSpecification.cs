using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class StreamSpecification
    {
        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "path")]
        public string Path { get; set; }

        [DataMember(Name = "bandwidth")]
        public int? Bandwidth { get; set; }

        [DataMember(Name = "resolution")]
        public string Resolution { get; set; }
    }
}