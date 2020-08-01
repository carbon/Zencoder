#nullable disable

using System.Collections.Generic;
using System.Text.Json.Serialization;

using Carbon.Json;

namespace Zencoder.Models
{
    public sealed class JobCreateRequest
    {
        private static readonly SerializationOptions options = new SerializationOptions {
            IgnoreNullValues = true
        };

        [JsonPropertyName("api_key")]
        public string ApiKey { get; set; }

		[JsonPropertyName("input")]
        public string Input { get; set; }

		[JsonPropertyName("outputs")]
        public List<OutputSpecification> Outputs { get; } = new List<OutputSpecification>();

        public JsonNode ToJson() => new JsonSerializer().Serialize(this, options);
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
