using System;
using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class NotificationSpecification
    {
        public NotificationSpecification() { }

        public NotificationSpecification(string format, Uri url)
        {
            Format = format;
            Url = url ?? throw new ArgumentNullException(nameof(url));
        }

        [DataMember(Name = "format")]
        public string Format { get; set; }

        [DataMember(Name = "url")]
        public Uri Url { get; set; }

        //  {"format": "xml", "url": "http://user:password@example.com/zencoder1"},
    }
}