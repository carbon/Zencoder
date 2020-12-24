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
        public string Format { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        //  {"format": "xml", "url": "http://user:password@example.com/zencoder1"},
    }
}