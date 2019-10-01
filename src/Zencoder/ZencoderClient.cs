using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

using Carbon.Json;

using Zencoder.Models;

namespace Zencoder
{
    public sealed class ZencoderClient
    {
        private const string baseUri = "https://app.zencoder.com/api/v2";

        private readonly string apiKey;

        private readonly HttpClient httpClient;

        public ZencoderClient(string apiKey)
            : this(apiKey, new HttpClient()) { }

        public ZencoderClient(string apiKey, HttpClient httpClient)
        {
            this.apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<JobCreateResponse> CreateJobAsync(JobCreateRequest request)
        {
            request.ApiKey = apiKey;

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, baseUri + "/jobs")
            {
                Content = new StringContent(request.ToJson().ToString(), Encoding.UTF8, "application/json")
            };

            var responseText = await SendAsync(httpRequest).ConfigureAwait(false);

            return JobCreateResponse.Parse(responseText);
        }

        public async Task<JobDetails> GetJobDetailsAsync(long jobId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/jobs/{jobId}?api_key={apiKey}"
           );

            var responseText = await SendAsync(httpRequest).ConfigureAwait(false);

            return JobDetails.ParseJSON(responseText);
        }

        public async Task<JobProgress> GetJobProgressAsync(long jobId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/jobs/{jobId}/progress?api_key={apiKey}"
            );

            var responseText = await SendAsync(httpRequest).ConfigureAwait(false);

            return Parse<JobProgress>(responseText);
        }

        public async Task<OutputProgress> GetJobOutputProgressAsync(long outputId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/outputs/{outputId}/progress?api_key={apiKey}"
            );

            var responseText = await SendAsync(httpRequest).ConfigureAwait(false);

            return Parse<OutputProgress>(responseText);
        }

        #region Helpers

        private static T Parse<T>(string text)
            where T : new()
        {
            return JsonObject.Parse(text).As<T>();
        }

        private async Task<string> SendAsync(HttpRequestMessage httpRequest)
        {
            using HttpResponseMessage response = await httpClient.SendAsync(httpRequest).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        #endregion
    }
}