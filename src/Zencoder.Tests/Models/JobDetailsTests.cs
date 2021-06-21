using System;
using System.Text.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class JobDetailsTests
    {
        [Fact]
        public void Deserialize()
        {
            var text = @"{
    ""id"": 141787724,
    ""input_media_file"": {
      ""created_at"": ""2015-02-08T03:11:49Z"",
      ""state"": ""Finished"",
      ""format"": ""mpeg4"",
      ""error_message"": null,
      ""error_class"": null,
      ""frame_rate"": 23.918,
      ""width"": 1280,
      ""height"": 720,
      ""duration_in_ms"": 34200,
      ""video_codec"": ""h264"",
      ""audio_codec"": ""aac"",
      ""audio_sample_rate"": 48000,
      ""total_bitrate_in_kbps"": 4069,
      ""file_size_bytes"": 17422532,
      ""url"": ""http://nterface.s3.amazonaws.com/23702951?AWSAccessKeyId=AKIAJL64HWU76LYAWDTA&Expires=1423408307&Signature=W7Hs04m%2FAmNEPIFIBmeeIQ6YK%2Fc%3D""
    },
    ""state"": ""Finished"",
    ""finished_at"": ""2015-02-08T03:12:31Z"",
    ""created_at"": ""2015-02-08T03:11:49Z"",
    ""output_media_files"": [
      {
        ""id"": 424919274,
        ""total_bitrate_in_kbps"": 0,
        ""audio_sample_rate"": 0,
        ""audio_codec"": null,
        ""video_codec"": null,
        ""duration_in_ms"": 0,
        ""height"": 0,
        ""file_size_bytes"": 0,
        ""width"": 0,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": null,
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:30Z"",
        ""label"": null,
        ""frame_rate"": 0,
        ""url"": ""http://test/23702951/dash/hq.mpd""
      },
      {
        ""id"": 424919270,
        ""total_bitrate_in_kbps"": 1099,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 540,
        ""file_size_bytes"": 4728465,
        ""width"": 960,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:22Z"",
        ""label"": ""dash-1350kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/dash/1350kbs/manifest.mpd""
      },
      {
        ""id"": 424919268,
        ""total_bitrate_in_kbps"": 1635,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 540,
        ""file_size_bytes"": 7012382,
        ""width"": 960,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:22Z"",
        ""label"": ""dash-2000kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/dash/2000kbs/manifest.mpd""
      },
      {
        ""id"": 424919267,
        ""total_bitrate_in_kbps"": 2874,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 720,
        ""file_size_bytes"": 12316711,
        ""width"": 1280,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:25Z"",
        ""label"": ""dash-3500kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/dash/3500kbs/manifest.mpd""
      },
      {
        ""id"": 424919272,
        ""total_bitrate_in_kbps"": 816,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 432,
        ""file_size_bytes"": 3520924,
        ""width"": 768,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:18Z"",
        ""label"": ""dash-1000kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/dash/1000kbs/manifest.mpd""
      },
      {
        ""id"": 424919263,
        ""total_bitrate_in_kbps"": 1635,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 540,
        ""file_size_bytes"": 6998034,
        ""width"": 960,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:12Z"",
        ""label"": ""mp4-2000kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/2000kbs.mp4""
      },
      {
        ""id"": 424919264,
        ""total_bitrate_in_kbps"": 1099,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 540,
        ""file_size_bytes"": 4714117,
        ""width"": 960,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:13Z"",
        ""label"": ""mp4-1350kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/1350kbs.mp4""
      },
      {
        ""id"": 424919265,
        ""total_bitrate_in_kbps"": 816,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 432,
        ""file_size_bytes"": 3506577,
        ""width"": 768,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:08Z"",
        ""label"": ""mp4-1000kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/1000kbs.mp4""
      },
      {
        ""id"": 424919262,
        ""total_bitrate_in_kbps"": 2874,
        ""audio_sample_rate"": 48000,
        ""audio_codec"": ""aac"",
        ""video_codec"": ""h264"",
        ""duration_in_ms"": 34260,
        ""height"": 720,
        ""file_size_bytes"": 12302362,
        ""width"": 1280,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": ""mpeg4"",
        ""state"": ""Finished"",
        ""finished_at"": ""2015-02-08T03:12:16Z"",
        ""label"": ""mp4-3500kbs"",
        ""frame_rate"": 30,
        ""url"": ""http://test/23702951/3500kbs.mp4""
      },
      {
        ""id"": 424919273,
        ""total_bitrate_in_kbps"": 0,
        ""audio_sample_rate"": 0,
        ""audio_codec"": null,
        ""video_codec"": null,
        ""duration_in_ms"": 0,
        ""height"": 0,
        ""file_size_bytes"": 0,
        ""width"": 0,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": null,
        ""state"": ""Skipped"",
        ""finished_at"": ""2015-02-08T03:11:55Z"",
        ""label"": null,
        ""frame_rate"": 0,
        ""url"": ""http://test/23702951/dash/hd.mpd""
      },
      {
        ""id"": 424919266,
        ""total_bitrate_in_kbps"": 0,
        ""audio_sample_rate"": 0,
        ""audio_codec"": null,
        ""video_codec"": null,
        ""duration_in_ms"": 0,
        ""height"": 0,
        ""file_size_bytes"": 0,
        ""width"": 0,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": null,
        ""state"": ""Skipped"",
        ""finished_at"": ""2015-02-08T03:11:55Z"",
        ""label"": ""dash-5000kbs"",
        ""frame_rate"": 0,
        ""url"": ""http://test/23702951/dash/5000kbs/manifest.mpd""
      },
      {
        ""id"": 424919261,
        ""total_bitrate_in_kbps"": 0,
        ""audio_sample_rate"": 0,
        ""audio_codec"": null,
        ""video_codec"": null,
        ""duration_in_ms"": 0,
        ""height"": 0,
        ""file_size_bytes"": 0,
        ""width"": 0,
        ""error_class"": null,
        ""error_message"": null,
        ""format"": null,
        ""state"": ""Skipped"",
        ""finished_at"": ""2015-02-08T03:11:55Z"",
        ""label"": ""mp4-5000kbs"",
        ""frame_rate"": 0,
        ""url"": ""http://test/23702951/5000kbs.mp4""
      }
    ],
    ""thumbnails"": [ ]
  }";


            var job = JobDetails.ParseJson(text);
        }

        [Fact]
        public void JobDetails2()
        {
            var text = @"{
  ""job"": {
    ""created_at"": ""2010-01-01T00:00:00Z"",
    ""finished_at"": ""2010-01-01T00:00:00Z"",
    ""updated_at"": ""2010-01-01T00:00:00Z"",
    ""submitted_at"": ""2010-01-01T00:00:00Z"",
    ""pass_through"": null,
    ""id"": 1,
    ""input_media_file"": {
      ""format"": ""mpeg4"",
      ""created_at"": ""2010-01-01T00:00:00Z"",
      ""frame_rate"": 29,
      ""finished_at"": ""2010-01-01T00:00:00Z"",
      ""updated_at"": ""2010-01-01T00:00:00Z"",
      ""duration_in_ms"": 24883,
      ""audio_sample_rate"": 48000,
      ""url"": ""s3://bucket/test.mp4"",
      ""id"": 1,
      ""error_message"": null,
      ""error_class"": null,
      ""audio_bitrate_in_kbps"": 95,
      ""audio_codec"": ""aac"",
      ""height"": 352,
      ""file_size_bytes"": 1862748,
      ""video_codec"": ""h264"",
      ""test"": false,
      ""total_bitrate_in_kbps"": 593,
      ""channels"": ""2"",
      ""width"": 624,
      ""video_bitrate_in_kbps"": 498,
      ""state"": ""finished"",
      ""md5_checksum"":""7f106918e02a69466afa0ee014174143""
    },
    ""test"": false,
    ""output_media_files"": [{
      ""format"": ""mpeg4"",
      ""created_at"": ""2010-01-01T00:00:00Z"",
      ""frame_rate"": 29,
      ""finished_at"": ""2010-01-01T00:00:00Z"",
      ""updated_at"": ""2010-01-01T00:00:00Z"",
      ""duration_in_ms"": 24883,
      ""audio_sample_rate"": 44100,
      ""url"": ""http://s3.amazonaws.com/bucket/video.mp4"",
      ""id"": 1,
      ""error_message"": null,
      ""error_class"": null,
      ""audio_bitrate_in_kbps"": 92,
      ""audio_codec"": ""aac"",
      ""height"": 352,
      ""file_size_bytes"": 1386663,
      ""video_codec"": ""h264"",
      ""test"": false,
      ""total_bitrate_in_kbps"": 443,
      ""channels"": ""2"",
      ""width"": 624,
      ""video_bitrate_in_kbps"": 351,
      ""state"": ""finished"",
      ""label"": ""Web"",
      ""md5_checksum"":""7f106918e02a69466afa0ee014172496""
    }],
    ""thumbnails"": [{
      ""created_at"": ""2010-01-01T00:00:00Z"",
      ""updated_at"": ""2010-01-01T00:00:00Z"",
      ""url"": ""http://s3.amazonaws.com/bucket/video/frame_0000.png"",
      ""id"": 1
    }],
    ""state"": ""finished""
  }
}";

            var job = JobDetails.ParseJson(text);


            Assert.Equal(ZencoderJobState.Finished, job.InputMediaFile.State);

        }

        [Fact]
        public void NoInputTest()
        {
            var text = @"{""job"":{""output_media_files"":[{""format"":null,""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":null,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""duration_in_ms"":null,""audio_sample_rate"":null,""url"":""http://test/10770912/1f0b2cdc474e4d7eb2f23c16a648c14a.mp4"",""id"":1558879,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":null,""audio_codec"":null,""height"":null,""file_size_bytes"":null,""label"":null,""video_codec"":null,""test"":false,""channels"":null,""width"":null,""video_bitrate_in_kbps"":null,""state"":""no_input""},{""format"":null,""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":null,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""duration_in_ms"":null,""audio_sample_rate"":null,""url"":""http://test/10770912/c3d125917a984b2ea2be6fd3fed2903d.webm"",""id"":1558878,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":null,""audio_codec"":null,""height"":null,""file_size_bytes"":null,""label"":null,""video_codec"":null,""test"":false,""channels"":null,""width"":null,""video_bitrate_in_kbps"":null,""state"":""no_input""}],""created_at"":""2011-02-01T23:11:31-05:00"",""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""submitted_at"":""2011-02-01T23:11:31-05:00"",""pass_through"":null,""input_media_file"":{""format"":""mpeg4"",""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":25,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:12:16-05:00"",""duration_in_ms"":30120,""audio_sample_rate"":48000,""url"":""http://motion.cmcdn.net/10770912.mov"",""id"":1254506,""error_message"":null,""error_class"":""UnsupportedCodecError"",""audio_bitrate_in_kbps"":1536,""audio_codec"":""pcm_s16le"",""height"":702,""file_size_bytes"":82896941,""video_codec"":""apple intermediate codec"",""test"":false,""channels"":""2"",""width"":1248,""video_bitrate_in_kbps"":20475,""state"":""failed""},""id"":1254534,""test"":false,""thumbnails"":[],""state"":""failed""}}";

            var job = JobDetails.ParseJson(text);

            var input = job.InputMediaFile;

            Assert.Equal(25f, input.FrameRate);
            Assert.Equal("mpeg4", input.Format);
            Assert.Null(input.ErrorMessage);
            Assert.Equal("UnsupportedCodecError", input.ErrorClass);
            Assert.Equal("pcm_s16le", input.AudioCodec);
            Assert.Equal("apple intermediate codec", input.VideoCodec);
            Assert.Equal(ZencoderJobState.Failed, input.State);

            Assert.True(input.HasError);

            Assert.Equal(ZencoderJobState.Failed, job.State);
        }

        [Fact]
        public void Details()
        {
            string text = @"{
    ""created_at"": ""2011-01-21T21:35:12-06:00"",
    ""input_media_file"": {
        ""format"": ""mpeg4"",
        ""created_at"": ""2011-01-21T21:35:12-06:00"",
        ""frame_rate"": 29,
        ""finished_at"": ""2011-01-21T21:35:26-06:00"",
        ""updated_at"": ""2011-01-21T21:35:26-06:00"",
        ""duration_in_ms"": 32065,
        ""audio_sample_rate"": 44100,
        ""url"": ""http://media.cmcdn.net/2486113.mov"",
        ""id"": 1130776,
        ""error_message"": null,
        ""error_class"": null,
        ""audio_bitrate_in_kbps"": 128,
        ""audio_codec"": ""aac"",
        ""height"": 240,
        ""file_size_bytes"": 3980484,
        ""video_codec"": ""mpeg4"",
        ""test"": false,
        ""channels"": ""2"",
        ""width"": 320,
        ""video_bitrate_in_kbps"": 829,
        ""state"": ""finished""
    },
    ""finished_at"": ""2011-01-21T21:37:36-06:00"",
    ""updated_at"": ""2011-01-21T21:37:36-06:00"",
    ""submitted_at"": ""2011-01-21T21:35:12-06:00"",
    ""pass_through"": null,
    ""thumbnails"": [
        {
            ""group_label"": null,
            ""format"": ""png"",
            ""created_at"": ""2011-01-21T21:37:36-06:00"",
            ""updated_at"": ""2011-01-21T21:37:36-06:00"",
            ""url"": ""http://test/2486113/320x240_32.png"",
            ""id"": 2272361,
            ""height"": 240,
            ""file_size_bytes"": 302,
            ""width"": 320
        },
        {
            ""group_label"": null,
            ""format"": ""png"",
            ""created_at"": ""2011-01-21T21:37:36-06:00"",
            ""updated_at"": ""2011-01-21T21:37:36-06:00"",
            ""url"": ""http://test/2486113/320x240_31.png"",
            ""id"": 2272360,
            ""height"": 240,
            ""file_size_bytes"": 302,
            ""width"": 320
        }
    ],
    ""id"": 1130804,
    ""output_media_files"": [
        {
            ""format"": ""mpeg4"",
            ""created_at"": ""2011-01-21T21:35:12-06:00"",
            ""frame_rate"": 29,
            ""finished_at"": ""2011-01-21T21:37:36-06:00"",
            ""updated_at"": ""2011-01-21T21:37:36-06:00"",
            ""duration_in_ms"": 32065,
            ""audio_sample_rate"": 44100,
            ""url"": ""http://test/2486113/67c6f15340224e61a2ab9ff9d7a15323.mp4"",
            ""id"": 1402040,
            ""error_message"": null,
            ""error_class"": null,
            ""audio_bitrate_in_kbps"": 150,
            ""audio_codec"": ""aac"",
            ""height"": 240,
            ""file_size_bytes"": 2693702,
            ""label"": null,
            ""video_codec"": ""h264"",
            ""test"": false,
            ""channels"": ""2"",
            ""width"": 320,
            ""video_bitrate_in_kbps"": 519,
            ""state"": ""finished""
        }
    ],
    ""test"": false,
    ""state"": ""finished""
    }";
            var job = JobDetails.ParseJson(text);

            // Console.WriteLine(XNode.FromObject(job).ToString());

            var thumb = job.Thumbnails[0];
            var output = job.OutputMediaFiles[0];

            Assert.Equal("png", thumb.Format);
            Assert.Equal(320, thumb.Width);
            Assert.Equal(240, thumb.Height);
            Assert.Equal(302, thumb.FileSizeBytes);
            Assert.Equal(new Uri("http://test/2486113/320x240_32.png"), thumb.Url);

            Assert.Equal(29f, job.InputMediaFile.FrameRate);
            Assert.False(job.InputMediaFile.HasError);


            Assert.Equal("mpeg4",                   output.Format);
            Assert.Equal(240,                       output.Height);
            Assert.Equal(2693702,                   output.FileSizeBytes);
            Assert.Equal("h264",                    output.VideoCodec);
            Assert.Equal(ZencoderJobState.Finished, output.State);

            Assert.Equal(2, job.Thumbnails.Count);
        }

        [Fact]
        public void ParseJobDetails()
        {
            var text = @"{
""created_at"": ""2010-01-01T00:00:00Z"",
""finished_at"": ""2010-01-01T00:00:00Z"",
""updated_at"": ""2010-01-01T00:00:00Z"",
""submitted_at"": ""2010-01-01T00:00:00Z"",
""pass_through"": null,
""id"": 1,
""input_media_file"": {
    ""format"": ""mpeg4"",
    ""created_at"": ""2010-01-01T00:00:00Z"",
    ""frame_rate"": 29,
    ""finished_at"": ""2010-01-01T00:00:00Z"",
    ""updated_at"": ""2010-01-01T00:00:00Z"",
    ""duration_in_ms"": 24883,
    ""audio_sample_rate"": 48000,
    ""url"": ""s3://bucket/test.mp4"",
    ""id"": 1,
    ""error_message"": null,
    ""error_class"": null,
    ""audio_bitrate_in_kbps"": 95,
    ""audio_codec"": ""aac"",
    ""height"": 352,
    ""file_size_bytes"": 1862748,
    ""video_codec"": ""h264"",
    ""test"": false,
    ""channels"": ""2"",
    ""width"": 624,
    ""video_bitrate_in_kbps"": 498,
    ""state"": ""finished""
},
""test"": false,
""output_media_files"": [{
    ""format"": ""mpeg4"",
    ""created_at"": ""2010-01-01T00:00:00Z"",
    ""frame_rate"": 29,
    ""finished_at"": ""2010-01-01T00:00:00Z"",
    ""updated_at"": ""2010-01-01T00:00:00Z"",
    ""duration_in_ms"": 24883,
    ""audio_sample_rate"": 44100,
    ""url"": ""http://s3.amazonaws.com/bucket/video.mp4"",
    ""id"": 1,
    ""error_message"": null,
    ""error_class"": null,
    ""audio_bitrate_in_kbps"": 92,
    ""audio_codec"": ""aac"",
    ""height"": 352,
    ""file_size_bytes"": 1386663,
    ""video_codec"": ""h264"",
    ""test"": false,
    ""channels"": ""2"",
    ""width"": 624,
    ""video_bitrate_in_kbps"": 351,
    ""state"": ""finished"",
    ""label"": ""Web""
}],
""thumbnails"": [{
    ""created_at"": ""2010-01-01T00:00:00Z"",
    ""updated_at"": ""2010-01-01T00:00:00Z"",
    ""url"": ""http://s3.amazonaws.com/bucket/video/frame_0000.png"",
    ""id"": 1
}],
""state"": ""finished""
}";
            var job = JsonSerializer.Deserialize<JobDetails>(text);


            var input = job.InputMediaFile;

            Assert.False(input.HasError);
            Assert.Single(job.OutputMediaFiles);

            var output = job.OutputMediaFiles[0];

            Assert.False(output.HasError);
            Assert.Equal("mpeg4", output.Format);
            Assert.Equal(24883, output.DurationInMs);
            Assert.Equal(1, output.Id);
            Assert.Equal("Web", output.Label);
            Assert.Equal(624, output.Width);
            Assert.Equal(352, output.Height);
            Assert.Equal(1386663, output.FileSizeBytes);
            Assert.Equal(ZencoderJobState.Finished, output.State);
        }

        [Fact]
        public void ParseJob()
        {
            var text = @"{""job"":{""thumbnails"":[],""created_at"":""2010-10-13T16:01:31-04:00"",""output_media_files"":[{""format"":""mpeg4"",""created_at"":""2010-10-13T16:01:31-04:00"",""frame_rate"":29,""finished_at"":""2010-10-13T16:01:53-04:00"",""updated_at"":""2010-10-13T16:01:53-04:00"",""duration_in_ms"":5038,""audio_sample_rate"":48000,""url"":""https://zencoder-live.s3.amazonaws.com:443/a054767b9cde8c22382716440fcbb775%2F4668501c716bf1cc8da463617f513463.mp4?Signature=sR6QwIyQR3sdmgQH8F%2Ft8mgpNk4%3D&Expires=1287086513&AWSAccessKeyId=AKIAIIEXNN2J4YDTRUVQ"",""id"":420991,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":111,""audio_codec"":""aac"",""height"":240,""file_size_bytes"":223526,""video_codec"":""h264"",""test"":true,""channels"":""2"",""label"":null,""width"":320,""video_bitrate_in_kbps"":239,""state"":""finished""}],""finished_at"":""2010-10-13T16:02:06-04:00"",""updated_at"":""2010-10-13T16:02:06-04:00"",""submitted_at"":""2010-10-13T16:01:31-04:00"",""pass_through"":null,""id"":325700,""input_media_file"":{""format"":""mpeg4"",""created_at"":""2010-10-13T16:01:31-04:00"",""frame_rate"":29,""finished_at"":""2010-10-13T16:01:44-04:00"",""updated_at"":""2010-10-13T16:01:44-04:00"",""duration_in_ms"":15296,""audio_sample_rate"":48000,""url"":""http://media.cmcdn.net/7265014.mov"",""id"":325696,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":199,""audio_codec"":""aac"",""height"":240,""file_size_bytes"":1894392,""video_codec"":""mpeg4"",""test"":true,""channels"":""2"",""width"":320,""video_bitrate_in_kbps"":790,""state"":""finished""},""test"":true,""state"":""finished""}}";

            var job = JobDetails.ParseJson(text);

            Assert.Equal(325700, job.Id);
            Assert.Equal(ZencoderJobState.Finished, job.State);

            var input = job.InputMediaFile;

            Assert.Equal("mpeg4", input.Format);
            Assert.Equal(29, input.FrameRate);
            Assert.Equal(15296, input.DurationInMs);

            Assert.Equal(240, input.Height);
            Assert.Equal(320, input.Width);
            Assert.Equal(48000, input.AudioSampleRate);
            Assert.Null(input.ErrorMessage);
            Assert.Equal("http://media.cmcdn.net/7265014.mov", input.Url);
        }

    }
}