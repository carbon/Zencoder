using System.Text.Json;
using System.Text.Json.Serialization;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class JobCreateRequestTests
    {
        [Fact]
        public void Serialize()
        {
            var job = new JobCreateRequest
            {
                ApiKey = "x",
                Input = "http://test/video.mp4",

                Outputs =  {
                    new OutputSpecification {
                        Label = "Square",
                        Width = 100,
                        Height = 100,
                        Url = "http://test/output.mp4",
                        Quality = 5,
                        Speed = 1,
                        Public = true,
                        VideoCodec = "vp8",
                        Notifications = new[] {
                            new NotificationSpecification("json", "http://test/")
                        }
                    }
                }
            };

           

            Assert.Equal(@"{
  ""api_key"": ""x"",
  ""input"": ""http://test/video.mp4"",
  ""outputs"": [
    {
      ""label"": ""Square"",
      ""url"": ""http://test/output.mp4"",
      ""video_codec"": ""vp8"",
      ""width"": 100,
      ""height"": 100,
      ""quality"": 5,
      ""speed"": 1,
      ""public"": true,
      ""notifications"": [
        {
          ""format"": ""json"",
          ""url"": ""http://test/""
        }
      ]
    }
  ]
}", JsonSerializer.Serialize(job, JSO.Default));
        }

        [Fact]
        public void Test2()
        {
            var job = new JobCreateRequest {
                Input = "https://test/7265014.mov",
                Outputs = {
                    new OutputSpecification {
                        Width = 768,
                        Height = 432,
                        Quality = 3,
                        Speed = 2,
                        Notifications = new NotificationSpecification[] {
                            new ("json", url: "http://test/zencoder/notifications/recieve")
                        }
                    }
                }
            };

            Assert.Equal(@"{
  ""input"": ""https://test/7265014.mov"",
  ""outputs"": [
    {
      ""width"": 768,
      ""height"": 432,
      ""quality"": 3,
      ""speed"": 2,
      ""notifications"": [
        {
          ""format"": ""json"",
          ""url"": ""http://test/zencoder/notifications/recieve""
        }
      ]
    }
  ]
}", JsonSerializer.Serialize(job, JSO.Default));
        }


        [Fact]
        public void Test3()
        {
            var job = new JobCreateRequest
            {
                ApiKey = "x",
                Input = "http://s3.amazonaws.com/zencodertesting/test.mov",
                Outputs =  {
                    new OutputSpecification {
                        Label = "mp4-1500k",
                        PrepareForSegmenting = new[] { "hls", "dash" },
                        AudioBitrate = 128,
                        DecoderBitrateCap = 1222,
                        DecoderBufferSize = 1833,
                        VideoBitrate = 1100,
                        Size = "1280x720",
                        Url = "s3://mybucket/full-examples/mp4/1500.mp4"
                    },

                    new OutputSpecification {
                        Label = "mp4-1000k",
                        PrepareForSegmenting = new[] { "hls", "dash" },
                        AudioBitrate = 128,
                        DecoderBitrateCap = 772,
                        DecoderBufferSize = 1158,
                        VideoBitrate = 695,
                        Size = "960x540",
                        Url = "s3://mybucket/full-examples/mp4/1000.mp4"
                    },

                    new OutputSpecification {
                        Label = "mp4-500k",
                        PrepareForSegmenting = new[] { "hls", "dash" },
                        AudioBitrate = 128,
                        DecoderBitrateCap = 322,
                        DecoderBufferSize = 483,
                        VideoBitrate = 290,
                        Size = "640x360",
                        Url = "s3://mybucket/full-examples/mp4/500.mp4"
                    },

                    new OutputSpecification {
                        Source = "mp4-1500k",
                        CopyVideo = true,
                        CopyAudio = true,
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/hls/1500.m3u8"
                    },

                    new OutputSpecification {
                        Source = "mp4-1000k",
                        CopyVideo = true,
                        CopyAudio = true,
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/hls/1000.m3u8"
                    },

                    new OutputSpecification {
                        Source = "mp4-500k",
                        CopyVideo = true,
                        CopyAudio = true,
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/hls/500.m3u8"
                    },

                    new OutputSpecification {
                        Label = "dash-1500k",
                        Source = "mp4-1500k",
                        CopyVideo = true,
                        CopyAudio = true,
                        StreamingDeliveryFormat = "dash",
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/dash/1500k/rendition.mpd"
                    },

                    new OutputSpecification {
                        Label = "dash-1000k",
                        Source = "mp4-1000k",
                        CopyVideo = true,
                        CopyAudio = true,
                        StreamingDeliveryFormat = "dash",
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/dash/1000k/rendition.mpd"
                    },

                    new OutputSpecification {
                        Label = "dash-500k",
                        Source = "mp4-500k",
                        CopyVideo = true,
                        CopyAudio = true,
                        StreamingDeliveryFormat = "dash",
                        Type = "segmented",
                        Url = "s3://mybucket/full-examples/dash/500k/rendition.mpd"
                    },

                    new OutputSpecification {
                        StreamingDeliveryFormat = "dash",
                        Type = "playlist",
                        Url = "s3://mybucket/full-examples/dash/manifest.mpd",
                        Streams = new StreamSpecification[] {
                            new () { Source = "dash-1500k", Path = "1500k" },
                            new () { Source = "dash-1000k", Path = "1000k" },
                            new () { Source = "dash-500k",  Path = "500k" }
                        }
                    }
                }
            };

            Assert.Equal(@"{
  ""api_key"": ""x"",
  ""input"": ""http://s3.amazonaws.com/zencodertesting/test.mov"",
  ""outputs"": [
    {
      ""label"": ""mp4-1500k"",
      ""url"": ""s3://mybucket/full-examples/mp4/1500.mp4"",
      ""size"": ""1280x720"",
      ""video_bitrate"": 1100,
      ""audio_bitrate"": 128,
      ""decoder_bitrate_cap"": 1222,
      ""decoder_buffer_size"": 1833,
      ""prepare_for_segmenting"": [
        ""hls"",
        ""dash""
      ]
    },
    {
      ""label"": ""mp4-1000k"",
      ""url"": ""s3://mybucket/full-examples/mp4/1000.mp4"",
      ""size"": ""960x540"",
      ""video_bitrate"": 695,
      ""audio_bitrate"": 128,
      ""decoder_bitrate_cap"": 772,
      ""decoder_buffer_size"": 1158,
      ""prepare_for_segmenting"": [
        ""hls"",
        ""dash""
      ]
    },
    {
      ""label"": ""mp4-500k"",
      ""url"": ""s3://mybucket/full-examples/mp4/500.mp4"",
      ""size"": ""640x360"",
      ""video_bitrate"": 290,
      ""audio_bitrate"": 128,
      ""decoder_bitrate_cap"": 322,
      ""decoder_buffer_size"": 483,
      ""prepare_for_segmenting"": [
        ""hls"",
        ""dash""
      ]
    },
    {
      ""type"": ""segmented"",
      ""url"": ""s3://mybucket/full-examples/hls/1500.m3u8"",
      ""source"": ""mp4-1500k"",
      ""copy_audio"": true,
      ""copy_video"": true
    },
    {
      ""type"": ""segmented"",
      ""url"": ""s3://mybucket/full-examples/hls/1000.m3u8"",
      ""source"": ""mp4-1000k"",
      ""copy_audio"": true,
      ""copy_video"": true
    },
    {
      ""type"": ""segmented"",
      ""url"": ""s3://mybucket/full-examples/hls/500.m3u8"",
      ""source"": ""mp4-500k"",
      ""copy_audio"": true,
      ""copy_video"": true
    },
    {
      ""type"": ""segmented"",
      ""label"": ""dash-1500k"",
      ""url"": ""s3://mybucket/full-examples/dash/1500k/rendition.mpd"",
      ""source"": ""mp4-1500k"",
      ""copy_audio"": true,
      ""copy_video"": true,
      ""streaming_delivery_format"": ""dash""
    },
    {
      ""type"": ""segmented"",
      ""label"": ""dash-1000k"",
      ""url"": ""s3://mybucket/full-examples/dash/1000k/rendition.mpd"",
      ""source"": ""mp4-1000k"",
      ""copy_audio"": true,
      ""copy_video"": true,
      ""streaming_delivery_format"": ""dash""
    },
    {
      ""type"": ""segmented"",
      ""label"": ""dash-500k"",
      ""url"": ""s3://mybucket/full-examples/dash/500k/rendition.mpd"",
      ""source"": ""mp4-500k"",
      ""copy_audio"": true,
      ""copy_video"": true,
      ""streaming_delivery_format"": ""dash""
    },
    {
      ""type"": ""playlist"",
      ""url"": ""s3://mybucket/full-examples/dash/manifest.mpd"",
      ""streaming_delivery_format"": ""dash"",
      ""streams"": [
        {
          ""source"": ""dash-1500k"",
          ""path"": ""1500k""
        },
        {
          ""source"": ""dash-1000k"",
          ""path"": ""1000k""
        },
        {
          ""source"": ""dash-500k"",
          ""path"": ""500k""
        }
      ]
    }
  ]
}", JsonSerializer.Serialize(job, JSO.Default));
        }

    }
}