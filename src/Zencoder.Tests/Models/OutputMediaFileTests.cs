using Carbon.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class OutputMediaFileTests
    {
        [Fact]
        public void Parse2()
        {
            var json = @"{
  ""audio_bitrate_in_kbps"": 96,
  ""audio_codec"": ""aac"",
  ""audio_sample_rate"": 48000,
  ""channels"": ""2"",
  ""duration_in_ms"": 24892,
  ""file_size_in_bytes"": 1862748,
  ""format"": ""mpeg4"",
  ""frame_rate"": 29.98,
  ""height"": 352,
  ""id"": 6816,
  ""job_id"": 6816,
  ""privacy"": false,
  ""state"": ""finished"",
  ""total_bitrate_in_kbps"": 594,
  ""url"": ""s3://example/file.mp4"",
  ""video_bitrate_in_kbps"": 498,
  ""video_codec"": ""h264"",
  ""width"": 624,
  ""md5_checksum"": ""7f106918e02a69466afa0ee014174143""
}";

            var output = JsonObject.Parse(json).As<OutputMediaFile>();

            Assert.Equal("mpeg4", output.Format);
            Assert.Equal(ZencoderJobState.Finished, output.State);
            Assert.Equal("s3://example/file.mp4", output.Url);
            Assert.Equal(29, (int)output.FrameRate);
            Assert.Equal(624, output.Width);
            Assert.Equal(352, output.Height);

        }

        [Fact]
        public void Parse()
        {
            var json = @"{
 ""error_message"": null,
 ""frame_rate"": 29,
 ""duration_in_ms"": 28864,
 ""video_codec"": ""h264"",
 ""audio_codec"": ""aac"",
 ""audio_sample_rate"": 48000,
 ""file_size_bytes"": 5923771,
 ""id"": 1297149,
 ""state"": ""Finished"",
 ""label"": null,
 ""format"": ""mpeg4"",
 ""width"": 768,
 ""height"": 432,
 ""url"": ""http://cmtemp.s3.amazonaws.com/eab7d5f990ac4108bfb855770d406506.mp4""
}";


            var output = JsonObject.Parse(json).As<OutputMediaFile>();

            Assert.Equal(null, output.ErrorMessage);
            Assert.Equal(29D, output.FrameRate);
            Assert.Equal("h264", output.VideoCodec);
            Assert.Equal(768, output.Width);
            Assert.Equal(432, output.Height);
            Assert.Equal("http://cmtemp.s3.amazonaws.com/eab7d5f990ac4108bfb855770d406506.mp4", output.Url);
        }
    }
}