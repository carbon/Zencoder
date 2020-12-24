#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class Notification
    {
        [JsonPropertyName("job")]
        public NotificationJob Job { get; set; }

        [JsonPropertyName("output")]
        public OutputMediaFile Output { get; set; }
    }

    public sealed class NotificationJob
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; set; }

        [JsonPropertyName("test")]
        public bool Test { get; set; }

        [JsonPropertyName("state")]
        public ZencoderJobState State { get; set; }
    }
}


// {"job":{"state":"finished","id":1234},"output":{"label":"web","url":"http://example.com/file.mp4","state":"finished","id":12345}}