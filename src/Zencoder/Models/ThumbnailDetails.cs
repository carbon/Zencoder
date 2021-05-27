#nullable disable

using System;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class Thumbnail
    {
        [JsonPropertyName("group_label")]
        public string GroupLabel { get; init; }

        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; init; }

        [JsonPropertyName("url")]
        public Uri Url { get; init; }

        [JsonPropertyName("format")]
        public string Format { get; init; }

        [JsonPropertyName("height")]
        public int Height { get; init; }

        [JsonPropertyName("width")]
        public int Width { get; init; }

        [JsonPropertyName("file_size_bytes")]
        public long FileSizeBytes { get; init; }
    }

    /*
	group_label: null,
    format: "png",
    created_at: "2011-01-21T21:37:36-06:00",
    updated_at: "2011-01-21T21:37:36-06:00",
    url: "http://cmtemp.s3.amazonaws.com/2486113/320x240_32.png",
    id: 2272361,
    height: 240,
    file_size_bytes: 302,
    width: 320
	*/
}