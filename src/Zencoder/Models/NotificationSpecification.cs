#nullable disable

using System;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class NotificationSpecification
    {
        public NotificationSpecification() { }

        public NotificationSpecification(string format, string url)
        {
            Format = format;
            Url = url ?? throw new ArgumentNullException(nameof(url));
        }

        [JsonPropertyName("format")]
        public string Format { get; init; }

        [JsonPropertyName("url")]
        public string Url { get; init; }

        //  {"format": "xml", "url": "http://user:password@example.com/zencoder1"},
    }
}