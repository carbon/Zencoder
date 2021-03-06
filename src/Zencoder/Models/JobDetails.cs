﻿#nullable disable

using System;
using System.Collections.Generic;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class JobDetails
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; init; }

        [JsonPropertyName("input_media_file")]
        public InputMediaFile InputMediaFile { get; init; }

        [JsonPropertyName("state")]
        public ZencoderJobState State { get; init; }

        [JsonPropertyName("finished_at")]
        public DateTime? FinishedAt { get; init; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; init; }

        [JsonPropertyName("output_media_files")]
        public List<OutputMediaFile> OutputMediaFiles { get; init; }

        [JsonPropertyName("thumbnails")]
        public List<Thumbnail> Thumbnails { get; init; }

        public static JobDetails ParseJson(string text)
        {
            // @"{""job"":{
        
            if (text.Contains("\"job\":"))
            {
                return JsonSerializer.Deserialize<WrappedJobDetails>(text)!.Job;
            }

            return JsonSerializer.Deserialize<JobDetails>(text)!;
        }

        [JsonIgnore]
        public bool IsFinished => State is ZencoderJobState.Finished;

        [JsonIgnore]
        public bool WasSkipped => State is ZencoderJobState.Skipped;
    }

    internal sealed class WrappedJobDetails
    {
        [JsonPropertyName("job")]
        public JobDetails Job { get; init; }
    }
}

/*
{
  "job": {
    "created_at": "2010-01-01T00:00:00Z",
    "finished_at": "2010-01-01T00:00:00Z",
    "updated_at": "2010-01-01T00:00:00Z",
    "submitted_at": "2010-01-01T00:00:00Z",
    "pass_through": null,
    "id": 1,
    "input_media_file": {
      "format": "mpeg4",
      "created_at": "2010-01-01T00:00:00Z",
      "frame_rate": 29,
      "finished_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "duration_in_ms": 24883,
      "audio_sample_rate": 48000,
      "url": "s3://bucket/test.mp4",
      "id": 1,
      "error_message": null,
      "error_class": null,
      "audio_bitrate_in_kbps": 95,
      "audio_codec": "aac",
      "height": 352,
      "file_size_bytes": 1862748,
      "video_codec": "h264",
      "test": false,
      "total_bitrate_in_kbps": 593,
      "channels": "2",
      "width": 624,
      "video_bitrate_in_kbps": 498,
      "state": "finished",
      "md5_checksum":"7f106918e02a69466afa0ee014174143"
    },
    "test": false,
    "output_media_files": [{
      "format": "mpeg4",
      "created_at": "2010-01-01T00:00:00Z",
      "frame_rate": 29,
      "finished_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "duration_in_ms": 24883,
      "audio_sample_rate": 44100,
      "url": "http://s3.amazonaws.com/bucket/video.mp4",
      "id": 1,
      "error_message": null,
      "error_class": null,
      "audio_bitrate_in_kbps": 92,
      "audio_codec": "aac",
      "height": 352,
      "file_size_bytes": 1386663,
      "video_codec": "h264",
      "test": false,
      "total_bitrate_in_kbps": 443,
      "channels": "2",
      "width": 624,
      "video_bitrate_in_kbps": 351,
      "state": "finished",
      "label": "Web",
      "md5_checksum":"7f106918e02a69466afa0ee014172496"
    }],
    "thumbnails": [{
      "created_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "url": "http://s3.amazonaws.com/bucket/video/frame_0000.png",
      "id": 1
    }],
    "state": "finished"
  }
}
*/

/*
 "job": {
    "created_at": "2010-01-01T00:00:00Z",
    "finished_at": "2010-01-01T00:00:00Z",
    "updated_at": "2010-01-01T00:00:00Z",
    "submitted_at": "2010-01-01T00:00:00Z",
    "pass_through": null,
    "id": 1,
    "input_media_file": {
      "format": "mpeg4",
      "created_at": "2010-01-01T00:00:00Z",
      "frame_rate": 29,
      "finished_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "duration_in_ms": 24883,
      "audio_sample_rate": 48000,
      "url": "s3://bucket/test.mp4",
      "id": 1,
      "error_message": null,
      "error_class": null,
      "audio_bitrate_in_kbps": 95,
      "audio_codec": "aac",
      "height": 352,
      "file_size_bytes": 1862748,
      "video_codec": "h264",
      "test": false,
      "channels": "2",
      "width": 624,
      "video_bitrate_in_kbps": 498,
      "state": "finished"
    },
    "test": false,
    "output_media_files": [{
      "format": "mpeg4",
      "created_at": "2010-01-01T00:00:00Z",
      "frame_rate": 29,
      "finished_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "duration_in_ms": 24883,
      "audio_sample_rate": 44100,
      "url": "http://s3.amazonaws.com/bucket/video.mp4",
      "id": 1,
      "error_message": null,
      "error_class": null,
      "audio_bitrate_in_kbps": 92,
      "audio_codec": "aac",
      "height": 352,
      "file_size_bytes": 1386663,
      "video_codec": "h264",
      "test": false,
      "channels": "2",
      "width": 624,
      "video_bitrate_in_kbps": 351,
      "state": "finished",
      "label": "Web"
    }],
    "thumbnails": [{
      "created_at": "2010-01-01T00:00:00Z",
      "updated_at": "2010-01-01T00:00:00Z",
      "url": "http://s3.amazonaws.com/bucket/video/frame_0000.png",
      "id": 1
    }],
    "state": "finished"
  }
*/
