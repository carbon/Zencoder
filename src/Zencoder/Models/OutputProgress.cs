#nullable disable

using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class OutputProgress
    {
        [DataMember(Name = "state")]
        public ZencoderJobState State { get; set; }

        [DataMember(Name = "progress")]
        public float Progress { get; set; }

        [DataMember(Name = "current_event")]
        public ZencoderEvent CurrentEvent { get; set; }
    }

    public enum ZencoderEvent
    {
        Inspecting  = 1,
        Downloading = 2,
        Transcoding = 3,
        Uploading   = 4
    }
}

/*
{
  "state": "processing",
  "current_event": "Transcodisng",
  "progress": "32.34567345"
}
*/
