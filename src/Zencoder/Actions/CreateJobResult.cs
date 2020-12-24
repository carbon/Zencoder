using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class CreateJobResult
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; set; }

        [JsonPropertyName("test")]
        public bool Test { get; set; }

        [JsonPropertyName("errors")]
        public string[]? Errors { get; set; }

        [JsonPropertyName("outputs")]
        public OutputInfo[]? Outputs { get; set; }

#nullable disable

        public sealed class OutputInfo
        {
            [JsonPropertyName("id")]
            [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
            public long Id { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }
    }
}