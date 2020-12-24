using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Zencoder.Models;

namespace Zencoder
{
    public sealed class ZencoderClient
    {
        private const string baseUri = "https://app.zencoder.com/api/v2";

        private readonly string apiKey;

        private readonly HttpClient httpClient;

        private static readonly JsonSerializerOptions jso = new () {
            IgnoreNullValues = true

        };
        public ZencoderClient(string apiKey)
            : this(apiKey, new HttpClient()) { }

        public ZencoderClient(string apiKey, HttpClient httpClient)
        {
            this.apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<CreateJobResult> CreateJobAsync(JobCreateRequest request)
        {
            request.ApiKey = apiKey;

            byte[] jsonUtf8 = JsonSerializer.SerializeToUtf8Bytes(request, jso);

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, baseUri + "/jobs") {
                Content = new ByteArrayContent(jsonUtf8) {
                    Headers = {
                        { "Content-Type", "application/json; charset=utf-8" }
                    }
                }
            };

            var result = await SendAsync<CreateJobResult>(httpRequest).ConfigureAwait(false);

            if (result.Errors is { Length: > 0 })
            {
                // {"errors":["Speed must be a number between 1 and 5."]}

                throw new Exception(result.Errors[0]);
            }

            return result;
        }

        public async Task<JobDetails> GetJobDetailsAsync(long jobId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/jobs/{jobId}?api_key={apiKey}"
           );

            var responseText = await SendAsync(httpRequest).ConfigureAwait(false);

            return JobDetails.ParseJson(responseText);
        }

        public async Task<JobProgress> GetJobProgressAsync(long jobId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/jobs/{jobId}/progress?api_key={apiKey}"
            );

            return await SendAsync<JobProgress>(httpRequest).ConfigureAwait(false);
        }

        public async Task<OutputProgress> GetJobOutputProgressAsync(long outputId)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                requestUri: $"{baseUri}/outputs/{outputId}/progress?api_key={apiKey}"
            );

            return await SendAsync<OutputProgress>(httpRequest).ConfigureAwait(false);
        }

        #region Helpers

        private async Task<string> SendAsync(HttpRequestMessage httpRequest)
        {
            using HttpResponseMessage response = await httpClient.SendAsync(httpRequest).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }

        private async Task<TResult> SendAsync<TResult>(HttpRequestMessage httpRequest)
        {
            using var response = await httpClient.SendAsync(httpRequest).ConfigureAwait(false);
            using var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            return (await JsonSerializer.DeserializeAsync<TResult>(responseStream).ConfigureAwait(false))!;
        }

        #endregion
    }
}