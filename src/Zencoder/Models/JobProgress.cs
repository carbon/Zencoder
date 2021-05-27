#nullable disable

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class JobProgress
    {
		[JsonPropertyName("state")]
        public ZencoderJobState State { get; init; }

		[JsonPropertyName("progress")]
        public float Progress { get; init; }

        [JsonPropertyName("input")]
        public JobProgressInput Input { get; init; }

		[JsonPropertyName("outputs")]
        public List<OutputProgress> Outputs { get; init; }

		[JsonIgnore]
		public bool IsFinished => State is ZencoderJobState.Finished;
	}

    public sealed class JobProgressInput
    {
		[JsonPropertyName("id")]
		[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; init; }

		[JsonPropertyName("state")]
        public ZencoderJobState State { get; init; }

		[JsonIgnore]
		public bool IsFinished => State is ZencoderJobState.Finished;
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