using System;
using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class Thumbnail
    {
        [DataMember(Name = "group_label")]
        public string GroupLabel { get; set; }

        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "url")]
        public Uri Url { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "file_size_bytes")]
        public long FileSizeBytes { get; set; }
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