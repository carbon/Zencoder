using System.Text.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class NotificationTests
    {
        [Fact]
        public void ParseNotification()
        {
            var text = @"{""job"":{""test"":true,""state"":""finished"",""id"":325565},""output"":{""url"":""https://zencoder-live.s3.amazonaws.com:443/37c689b6d9a3c437a1c87c449673e5e6%2Fe70c05fccf5779a035b1cadf9907a3c8.mp4?Signature=Yxik%2F59N4pelVqCyZ3cRkyy2XyQ%3D&Expires=1287083090&AWSAccessKeyId=AKIAIIEXNN2J4YDTRUVQ"",""state"":""finished"",""label"":null,""id"":420758}}";

            var n = JsonSerializer.Deserialize<Notification>(text);

            Assert.Equal(325565, n.Job.Id);
            Assert.Equal(ZencoderJobState.Finished, n.Job.State);

            Assert.Equal(420758, n.Output.Id);
            Assert.Equal("https://zencoder-live.s3.amazonaws.com:443/37c689b6d9a3c437a1c87c449673e5e6%2Fe70c05fccf5779a035b1cadf9907a3c8.mp4?Signature=Yxik%2F59N4pelVqCyZ3cRkyy2XyQ%3D&Expires=1287083090&AWSAccessKeyId=AKIAIIEXNN2J4YDTRUVQ", n.Output.Url);
        }

        [Fact]
        public void ParseNotification3()
        {
            var text = @"{""output"":{""url"":""http://cmtemp.s3.amazonaws.com/2486113/67c6f15340224e61a2ab9ff9d7a15323.mp4"",""state"":""finished"",""label"":null,""id"":1402040},""job"":{""state"":""finished"",""id"":1130804}}";


            var n = JsonSerializer.Deserialize<Notification>(text);

            Assert.Equal(1402040, n.Output.Id);
            Assert.Equal(1130804, n.Job.Id);
            Assert.Equal(ZencoderJobState.Finished, n.Job.State);

        }

        [Fact]
        public void ParseNotification2()
        {
            var text = @"{""job"":{""test"":true,""state"":""failed"",""id"":335325},""output"":{""error_link"":""http://zencoder.com/docs/errors/#NoMediaError"",""state"":""failed"",""label"":null,""id"":436071,""error_message"":""This file does not appear to be a valid media file. No audio or video tracks were detected.""}}";


            var n = JsonSerializer.Deserialize<Notification>(text);

            Assert.True(n.Job.Test);
            Assert.Equal(335325, n.Job.Id);
            Assert.Equal(ZencoderJobState.Failed, n.Job.State);

            var output = n.Output;

            Assert.Equal(ZencoderJobState.Failed, output.State);
            Assert.Equal("This file does not appear to be a valid media file. No audio or video tracks were detected.", output.ErrorMessage);
        }

    }
}