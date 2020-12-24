#nullable disable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class JobCreateRequest
    {
        [JsonPropertyName("api_key")]
        public string ApiKey { get; set; }

		[JsonPropertyName("input")]
        public string Input { get; set; }

#nullable enable

		// e.g. "us-virginia"
		[JsonPropertyName("region")]
		public string? Region { get; set; }

		[JsonPropertyName("test")]
		public bool? Test { get; set; }

		[JsonPropertyName("credentials")]
		public string? Credentials { get; set; }

#nullable disable

		[JsonPropertyName("outputs")]
        public List<OutputSpecification> Outputs { get; } = new ();
    }
}

/*
{
	"api_key": "x",
	"input": "s3://bucket-name/file-name.avi",
	"outputs": [
	{
		"label": "iPhone",
		"url": "s3://output-bucket/output-file-1-name.mp4",
		"width": "480",
		"height": "320"
	},
	{
		"label": "WebHD",
		"url": "s3://output-bucket/output-file-2-name.mp4",
		"width": "1280",
		"height": "720"
	}
	]
}
*/
