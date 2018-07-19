using Carbon.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class JobProgressTests
    {
        [Fact]
        public void Parse()
        {
            var text = @"{
  ""state"": ""processing"",
  ""progress"": 32.34567345,
  ""input"": {
    ""id"": 1234,
    ""state"": ""finished""
  },
  ""outputs"": [
    {
      ""id"": 4567,
      ""state"": ""processing"",
      ""current_event"": ""Transcoding"",
      ""current_event_progress"": 25.0323,
      ""progress"": 35.23532
    },
    {
      ""id"": 4568,
      ""state"": ""processing"",
      ""current_event"": ""Uploading"",
      ""current_event_progress"": 82.32,
      ""progress"": 95.3223
    }
  ]
}";

            var progress = JsonObject.Parse(text).As<JobProgress>();


            Assert.Equal(2, progress.Outputs.Count);
            Assert.Equal(ZencoderJobState.Processing, progress.Outputs[0].State);
            Assert.Equal(32, (int)progress.Progress);
            Assert.Equal(ZencoderJobState.Processing, progress.State);
        }
    }
}