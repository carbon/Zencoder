#nullable disable

using System;
using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public class MediaFileBase
    {
        [JsonPropertyName("state")]
        public ZencoderJobState State { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

#nullable enable

        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("error_class")]
        public string? ErrorClass { get; set; }

        [JsonPropertyName("frame_rate")]
        public float? FrameRate { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("duration_in_ms")]
        public long? DurationInMs { get; set; }

        [JsonPropertyName("video_codec")]
        public string? VideoCodec { get; set; }

        [JsonPropertyName("audio_codec")]
        public string? AudioCodec { get; set; }

        [JsonPropertyName("audio_sample_rate")]
        public int? AudioSampleRate { get; set; }

        [JsonPropertyName("total_bitrate_in_kbps")]
        public int? TotalBitrateInKbps { get; set; }

        [JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

#nullable disable

        [JsonPropertyName("url")]
        public string Url { get; set; }

        // BASE 10
        [JsonIgnore]
        public int Bitrate => FileSizeBytes.HasValue ? (int)(((FileSizeBytes * 8) / 1000) / Duration.TotalSeconds) : 0;

        [JsonIgnore]
        public TimeSpan Duration => DurationInMs is long value ? TimeSpan.FromMilliseconds(value) : TimeSpan.Zero;

        [JsonIgnore]
        public bool HasError => !string.IsNullOrEmpty(ErrorMessage) || !string.IsNullOrEmpty(ErrorClass);
    }

    public sealed class InputMediaFile : MediaFileBase
    {
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public sealed class OutputMediaFile : MediaFileBase
    {
        [JsonPropertyName("id")]
        [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
        public long Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("finished_at")]
        public DateTime? FinishedAt { get; set; }

        [JsonIgnore]
        public bool IsFinished => State == ZencoderJobState.Finished;
    }
}

/*
{
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
}
*/
