using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class CreateJobResult
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; init; }

        [JsonPropertyName("test")]
        public bool Test { get; init; }

        [JsonPropertyName("errors")]
        public string[]? Errors { get; init; }

        [JsonPropertyName("outputs")]
        public OutputInfo[]? Outputs { get; init; }

        public sealed class OutputInfo
        {
            [JsonPropertyName("id")]
            [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
            public long Id { get; init; }

#nullable disable

            [JsonPropertyName("url")]
            public string Url { get; init; }
        }
    }
}