using Carbon.Json;

using Xunit;

namespace Zencoder.Models.Tests
{
    public class JobCreateResultTests
    {
        [Fact]
        public void ParseCreateJobResult()
        {
            string text = @"{""test"":true,""outputs"":[{""id"":435486,""url"":""https://zencoder-live.s3.amazonaws.com:443/29dec4095cb32a81984f83653e2c8386%2F4162c1ab5326a4a0a1199fb54d2dbb20.mp4?Signature=q%2BcWjkiE7QrRojm%2BZyKJ6Ll1m0w%3D&Expires=1287354345&AWSAccessKeyId=AKIAIIEXNN2J4YDTRUVQ"",""label"":null}],""id"":334767}";

            var result = JsonObject.Parse(text).As<JobCreateResponse>();

            Assert.Equal(334767, result.Id);
            Assert.Equal(1, result.Outputs.Length);
            Assert.Equal(435486, result.Outputs[0].Id);
            Assert.Equal("https://zencoder-live.s3.amazonaws.com:443/29dec4095cb32a81984f83653e2c8386%2F4162c1ab5326a4a0a1199fb54d2dbb20.mp4?Signature=q%2BcWjkiE7QrRojm%2BZyKJ6Ll1m0w%3D&Expires=1287354345&AWSAccessKeyId=AKIAIIEXNN2J4YDTRUVQ", result.Outputs[0].Url);
        }
    }
}
