using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public class OutputProgress
    {
        [JsonPropertyName("state")]
        public ZencoderJobState State { get; set; }

        [JsonPropertyName("progress")]
        public float Progress { get; set; }

        [JsonPropertyName("current_event")]
        public ZencoderEventType CurrentEvent { get; set; }
    }
}

/*
{
  "state": "processing",
  "current_event": "Transcodisng",
  "progress": "32.34567345"
}
*/
