#nullable disable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class JobProgress
    {
		[JsonPropertyName("state")]
        public ZencoderJobState State { get; set; }

		[JsonPropertyName("progress")]
        public float Progress { get; set; }

        [JsonPropertyName("input")]
        public JobProgressInput Input { get; set; }

		[JsonPropertyName("outputs")]
        public List<OutputProgress> Outputs { get; set; }
    }

    public sealed class JobProgressInput
    {
		[JsonPropertyName("id")]
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; set; }

		[JsonPropertyName("state")]
        public ZencoderJobState State { get; set; }
    }

    /*
	{
	  "state": "processing",
	  "progress": 32.34567345,
	  "input": {
		"id": 1234,
		"state": "finished"
	  },
	  "outputs": [
		{
		  "id": 4567,
		  "state": "processing",
		  "current_event": "Transcoding",
		  "current_event_progress": 25.0323,
		  "progress": 35.23532
		},
		{
		  "id": 4568,
		  "state": "processing",
		  "current_event": "Uploading",
		  "current_event_progress": 82.32,
		  "progress": 95.3223
		}
	  ]
	}
	*/
}