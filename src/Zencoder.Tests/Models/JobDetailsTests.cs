using System;

using Carbon.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class JobDetailsTests
    {
        [Fact]
        public void JobDetails3()
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/hq.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/1350kbs/manifest.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/2000kbs/manifest.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/3500kbs/manifest.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/1000kbs/manifest.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/2000kbs.mp4""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/1350kbs.mp4""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/1000kbs.mp4""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/3500kbs.mp4""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/hd.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/dash/5000kbs/manifest.mpd""
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
        ""url"": ""http://cmmotion.s3.amazonaws.com/23702951/5000kbs.mp4""
      }
    ],
    ""thumbnails"": [ ]
  }";


            var job = JobDetails.ParseJSON(text);
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

            var job = JobDetails.ParseJSON(text);


            Assert.Equal(ZencoderJobState.Finished, job.InputMediaFile.State);

        }

        [Fact]
        public void NoInputTest()
        {
            var text = @"{""job"":{""output_media_files"":[{""format"":null,""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":null,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""duration_in_ms"":null,""audio_sample_rate"":null,""url"":""http://cmtemp.s3.amazonaws.com/10770912/1f0b2cdc474e4d7eb2f23c16a648c14a.mp4"",""id"":1558879,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":null,""audio_codec"":null,""height"":null,""file_size_bytes"":null,""label"":null,""video_codec"":null,""test"":false,""channels"":null,""width"":null,""video_bitrate_in_kbps"":null,""state"":""no_input""},{""format"":null,""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":null,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""duration_in_ms"":null,""audio_sample_rate"":null,""url"":""http://cmtemp.s3.amazonaws.com/10770912/c3d125917a984b2ea2be6fd3fed2903d.webm"",""id"":1558878,""error_message"":null,""error_class"":null,""audio_bitrate_in_kbps"":null,""audio_codec"":null,""height"":null,""file_size_bytes"":null,""label"":null,""video_codec"":null,""test"":false,""channels"":null,""width"":null,""video_bitrate_in_kbps"":null,""state"":""no_input""}],""created_at"":""2011-02-01T23:11:31-05:00"",""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:11:58-05:00"",""submitted_at"":""2011-02-01T23:11:31-05:00"",""pass_through"":null,""input_media_file"":{""format"":""mpeg4"",""created_at"":""2011-02-01T23:11:31-05:00"",""frame_rate"":25,""finished_at"":""2011-02-01T23:11:58-05:00"",""updated_at"":""2011-02-01T23:12:16-05:00"",""duration_in_ms"":30120,""audio_sample_rate"":48000,""url"":""http://motion.cmcdn.net/10770912.mov"",""id"":1254506,""error_message"":null,""error_class"":""UnsupportedCodecError"",""audio_bitrate_in_kbps"":1536,""audio_codec"":""pcm_s16le"",""height"":702,""file_size_bytes"":82896941,""video_codec"":""apple intermediate codec"",""test"":false,""channels"":""2"",""width"":1248,""video_bitrate_in_kbps"":20475,""state"":""failed""},""id"":1254534,""test"":false,""thumbnails"":[],""state"":""failed""}}";

            var job = JobDetails.ParseJSON(text);

            var input = job.InputMediaFile;

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
created_at: ""2011-01-21T21:35:12-06:00"",
input_media_file: {
    format: ""mpeg4"",
    created_at: ""2011-01-21T21:35:12-06:00"",
    frame_rate: 29,
    finished_at: ""2011-01-21T21:35:26-06:00"",
    updated_at: ""2011-01-21T21:35:26-06:00"",
    duration_in_ms: 32065,
    audio_sample_rate: 44100,
    url: ""http://media.cmcdn.net/2486113.mov"",
    id: 1130776,
    error_message: null,
    error_class: null,
    audio_bitrate_in_kbps: 128,
    audio_codec: ""aac"",
    height: 240,
    file_size_bytes: 3980484,
    video_codec: ""mpeg4"",
    test: false,
    channels: ""2"",
    width: 320,
    video_bitrate_in_kbps: 829,
    state: ""finished""
},
finished_at: ""2011-01-21T21:37:36-06:00"",
updated_at: ""2011-01-21T21:37:36-06:00"",
submitted_at: ""2011-01-21T21:35:12-06:00"",
pass_through: null,
thumbnails: [
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:36-06:00"",
    updated_at: ""2011-01-21T21:37:36-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_32.png"",
    id: 2272361,
    height: 240,
    file_size_bytes: 302,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:36-06:00"",
    updated_at: ""2011-01-21T21:37:36-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_31.png"",
    id: 2272360,
    height: 240,
    file_size_bytes: 302,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:36-06:00"",
    updated_at: ""2011-01-21T21:37:36-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_30.png"",
    id: 2272359,
    height: 240,
    file_size_bytes: 134631,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_29.png"",
    id: 2272358,
    height: 240,
    file_size_bytes: 134963,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_28.png"",
    id: 2272357,
    height: 240,
    file_size_bytes: 115940,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_27.png"",
    id: 2272356,
    height: 240,
    file_size_bytes: 92379,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_26.png"",
    id: 2272355,
    height: 240,
    file_size_bytes: 99815,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_25.png"",
    id: 2272354,
    height: 240,
    file_size_bytes: 159372,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_24.png"",
    id: 2272353,
    height: 240,
    file_size_bytes: 118506,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_23.png"",
    id: 2272352,
    height: 240,
    file_size_bytes: 160828,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_22.png"",
    id: 2272351,
    height: 240,
    file_size_bytes: 113667,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_21.png"",
    id: 2272350,
    height: 240,
    file_size_bytes: 107913,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_20.png"",
    id: 2272349,
    height: 240,
    file_size_bytes: 103166,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_19.png"",
    id: 2272348,
    height: 240,
    file_size_bytes: 91733,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_18.png"",
    id: 2272347,
    height: 240,
    file_size_bytes: 72604,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_17.png"",
    id: 2272346,
    height: 240,
    file_size_bytes: 92816,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_16.png"",
    id: 2272345,
    height: 240,
    file_size_bytes: 102389,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_15.png"",
    id: 2272344,
    height: 240,
    file_size_bytes: 111294,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_14.png"",
    id: 2272343,
    height: 240,
    file_size_bytes: 76339,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_13.png"",
    id: 2272342,
    height: 240,
    file_size_bytes: 77143,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_12.png"",
    id: 2272341,
    height: 240,
    file_size_bytes: 141793,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_11.png"",
    id: 2272340,
    height: 240,
    file_size_bytes: 130836,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_10.png"",
    id: 2272339,
    height: 240,
    file_size_bytes: 113224,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_9.png"",
    id: 2272338,
    height: 240,
    file_size_bytes: 111764,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_8.png"",
    id: 2272337,
    height: 240,
    file_size_bytes: 117830,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_7.png"",
    id: 2272336,
    height: 240,
    file_size_bytes: 116437,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_6.png"",
    id: 2272335,
    height: 240,
    file_size_bytes: 118775,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_5.png"",
    id: 2272334,
    height: 240,
    file_size_bytes: 117155,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_4.png"",
    id: 2272333,
    height: 240,
    file_size_bytes: 137066,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_3.png"",
    id: 2272332,
    height: 240,
    file_size_bytes: 126571,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_2.png"",
    id: 2272331,
    height: 240,
    file_size_bytes: 145457,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_1.png"",
    id: 2272330,
    height: 240,
    file_size_bytes: 136059,
    width: 320
    },
    {
    group_label: null,
    format: ""png"",
    created_at: ""2011-01-21T21:37:35-06:00"",
    updated_at: ""2011-01-21T21:37:35-06:00"",
    url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_0.png"",
    id: 2272329,
    height: 240,
    file_size_bytes: 302,
    width: 320
    }
],
id: 1130804,
output_media_files: [
    {
    format: ""mpeg4"",
    created_at: ""2011-01-21T21:35:12-06:00"",
    frame_rate: 29,
    finished_at: ""2011-01-21T21:37:36-06:00"",
    updated_at: ""2011-01-21T21:37:36-06:00"",
    duration_in_ms: 32065,
    audio_sample_rate: 44100,
    url: ""http://cmtemp.s3.amazonaws.com/2486113/67c6f15340224e61a2ab9ff9d7a15323.mp4"",
    id: 1402040,
    error_message: null,
    error_class: null,
    audio_bitrate_in_kbps: 150,
    audio_codec: ""aac"",
    height: 240,
    file_size_bytes: 2693702,
    label: null,
    video_codec: ""h264"",
    test: false,
    channels: ""2"",
    width: 320,
    video_bitrate_in_kbps: 519,
    state: ""finished""
    }
],
test: false,
state: ""finished""
}";
            var job = JobDetails.ParseJSON(text);

            // Console.WriteLine(XNode.FromObject(job).ToString());

            var thumb = job.Thumbnails[0];

            Assert.Equal(320, thumb.Width);
            Assert.Equal(240, thumb.Height);
            Assert.Equal(new Uri("http://cmtemp.s3.amazonaws.com/2486113/320x240_32.png"), thumb.Url);

            Assert.Equal(29D, job.InputMediaFile.FrameRate);
            Assert.False(job.InputMediaFile.HasError);

            Assert.Equal(33, job.Thumbnails.Count);

            /*
			 group_label: null,
        format: ""png"",
        created_at: ""2011-01-21T21:37:36-06:00"",
        updated_at: ""2011-01-21T21:37:36-06:00"",
        url: ""http://cmtemp.s3.amazonaws.com/2486113/320x240_32.png"",
        id: 2272361,
        height: 240,
        file_size_bytes: 302,
        width: 320
			*/

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
            var job = JsonObject.Parse(text).As<JobDetails>();


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

            var job = JobDetails.ParseJSON(text);

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