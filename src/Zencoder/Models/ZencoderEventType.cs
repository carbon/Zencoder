using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ZencoderEventType
    {
        Inspecting  = 1,
        Downloading = 2,
        Transcoding = 3,
        Uploading   = 4
    }
}