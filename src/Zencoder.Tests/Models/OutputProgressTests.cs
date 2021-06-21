using System.Text.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class OutputProgressTests
    {
        [Fact]
        public void Parse1()
        {
            string text = @"{""current_event"":""Uploading"",""state"":""finished""}";

            var progress = JsonSerializer.Deserialize<OutputProgress>(text);

            Assert.Equal(ZencoderEventType.Uploading, progress.CurrentEvent);
            Assert.Equal(ZencoderJobState.Finished, progress.State);
        }

        [Fact]
        public void Parse2()
        {
            var progress = JsonSerializer.Deserialize<OutputProgress>(@"{""state"": ""processing"",""current_event"": ""Transcoding"",""progress"": 32.34567345}");

            Assert.Equal(ZencoderJobState.Processing, progress.State);
            Assert.Equal(32.34567, progress.Progress, 5);

            Assert.Equal(ZencoderEventType.Transcoding, progress.CurrentEvent);
        }
    }
}