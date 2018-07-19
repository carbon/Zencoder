using Carbon.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class OutputProgressTests
    {
        [Fact]
        public void Parse1()
        {
            string text = @"{""current_event"":""Uploading"",""state"":""finished""}";

            var progress = JsonObject.Parse(text).As<OutputProgress>();

            Assert.Equal(ZencoderEvent.Uploading, progress.CurrentEvent);
            Assert.Equal(ZencoderJobState.Finished, progress.State);
        }

        [Fact]
        public void Parse2()
        {
            var progress = JsonObject.Parse(@"{""state"": ""processing"",""current_event"": ""Transcoding"",""progress"": 32.34567345}").As<OutputProgress>();

            Assert.Equal(ZencoderJobState.Processing, progress.State);
            Assert.Equal(32.34567D, progress.Progress, 5);

            Assert.Equal(ZencoderEvent.Transcoding, progress.CurrentEvent);
        }
    }
}