#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class StreamSpecification
    {
        [JsonPropertyName("source")]
        public string Source { get; init; }

        [JsonPropertyName("path")]
        public string Path { get; init; }

        [JsonPropertyName("bandwidth")]
        public int? Bandwidth { get; init; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; init; }
    }
}