using System;
using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class MediaFileBase
    {
        [DataMember(Name = "state")]
        public ZencoderJobState State { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }

        [DataMember(Name = "error_message")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "error_class")]
        public string ErrorClass { get; set; }

        [DataMember(Name = "frame_rate")]
        public float FrameRate { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "duration_in_ms")]
        public long DurationInMs { get; set; }

        [DataMember(Name = "video_codec")]
        public string VideoCodec { get; set; }

        [DataMember(Name = "audio_codec")]
        public string AudioCodec { get; set; }

        [DataMember(Name = "audio_sample_rate")]
        public int AudioSampleRate { get; set; }

        [DataMember(Name = "total_bitrate_in_kbps")]
        public int TotalBitrateInKbps { get; set; }

        [DataMember(Name = "file_size_bytes")]
        public long FileSizeBytes { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        #region Helpers

        // BASE 10
        [IgnoreDataMember]
        public int Bitrate
            => (int)(((FileSizeBytes * 8) / 1000) / Duration.TotalSeconds);

        [IgnoreDataMember]
        public TimeSpan Duration
            => TimeSpan.FromMilliseconds(DurationInMs);

        [IgnoreDataMember]
        public bool HasError => !string.IsNullOrEmpty(ErrorMessage) || !string.IsNullOrEmpty(ErrorClass);

        #endregion
    }

    public sealed class InputMediaFile : MediaFileBase
    {
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public sealed class OutputMediaFile : MediaFileBase
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "label")]
        public string Label { get; set; }

        [DataMember(Name = "finished_at")]
        public DateTime? FinishedAt { get; set; }

        #region Helper Properties

        [IgnoreDataMember]
        public bool IsFinished => State == ZencoderJobState.Finished;

        #endregion
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
