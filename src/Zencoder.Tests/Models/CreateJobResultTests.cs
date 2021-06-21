using System.Text.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class CreateJobResultTests
    {
        [Fact]
        public void CanDeserialize()
        {
            string text = @"{
  ""test"":true,
  ""outputs"":[
    {
      ""id"":435486,
       ""url"":""https://zencoder-live.s3.amazonaws.com:443/x.mp4"",
      ""label"":null
    }
  ],
  ""id"":1
}";

            var result = JsonSerializer.Deserialize<CreateJobResult>(text);

            Assert.Equal(1, result.Id);
            Assert.True(result.Test);
            Assert.Single(result.Outputs);
            Assert.Equal(435486, result.Outputs[0].Id);
            Assert.Equal("https://zencoder-live.s3.amazonaws.com:443/x.mp4", result.Outputs[0].Url);
        }
    }
}