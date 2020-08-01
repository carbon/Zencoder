#nullable disable

using System.Runtime.Serialization;
using System.Text.Json.Serialization;

using Carbon.Json;

namespace Zencoder.Models
{
    public class Notification
    {
        [JsonPropertyName("job")]
        public NotificationJob Job { get; set; }

        [JsonPropertyName("output")]
        public OutputMediaFile Output { get; set; }

        public static Notification ParseJson(string jsonText)
        {
            return JsonObject.Parse(jsonText).As<Notification>();
        }
    }

    public class NotificationJob
    {
        public long Id { get; set; }

        public bool Test { get; set; }

        public ZencoderJobState State { get; set; }
    }
}


// {"job":{"state":"finished","id":1234},"output":{"label":"web","url":"http://example.com/file.mp4","state":"finished","id":12345}}