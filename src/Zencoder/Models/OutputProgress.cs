using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class OutputProgress
    {
        [JsonPropertyName("state")]
        public ZencoderJobState State { get; init; }

        [JsonPropertyName("progress")]
        public float Progress { get; init; }

        [JsonPropertyName("current_event")]
        public ZencoderEventType CurrentEvent { get; init; }

        [JsonIgnore]
        public bool IsFinished => State is ZencoderJobState.Finished;
    }
}

/*
{
  "state": "processing",
  "current_event": "Transcodisng",
  "progress": "32.34567345"
}
*/
