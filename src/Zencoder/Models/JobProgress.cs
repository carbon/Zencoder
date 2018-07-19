using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class JobProgress
    {
        [DataMember(Name = "state")]
        public ZencoderJobState State { get; set; }

        [DataMember(Name = "progress")]
        public float Progress { get; set; }

        [DataMember(Name = "input")]
        public JobProgressInput Input { get; set; }

        [DataMember(Name = "outputs")]
        public List<OutputProgress> Outputs { get; set; }
    }

    public class JobProgressInput
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "state")]
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