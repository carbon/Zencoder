#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class Notification
    {
        [JsonPropertyName("job")]
        public NotificationJob Job { get; init; }

        [JsonPropertyName("output")]
        public OutputMediaFile Output { get; init; }
    }

    public sealed class NotificationJob
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; init; }

        [JsonPropertyName("test")]
        public bool Test { get; init; }

        [JsonPropertyName("state")]
        public ZencoderJobState State { get; init; }

        [JsonIgnore]
        public bool IsFinished => State is ZencoderJobState.Finished;
    }
}


// {"job":{"state":"finished","id":1234},"output":{"label":"web","url":"http://example.com/file.mp4","state":"finished","id":12345}}