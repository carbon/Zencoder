#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class StreamSpecification
    {
        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("bandwidth")]
        public int? Bandwidth { get; set; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }
    }
}