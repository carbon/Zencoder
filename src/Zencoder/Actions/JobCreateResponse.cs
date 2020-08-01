#nullable disable

using System;
using System.Text.Json.Serialization;

using Carbon.Json;

namespace Zencoder.Models
{
    public class JobCreateResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("outputs")]
        public OutputInfo[] Outputs { get; set; }

        public static JobCreateResponse Parse(string jsonText)
        {
            var json = JsonObject.Parse(jsonText);

            if (json.ContainsKey("errors"))
            {
                // {"errors":["Speed must be a number between 1 and 5."]}

                throw new Exception(json["errors"][0].ToString());
            }

            return json.As<JobCreateResponse>();

            /* 
		    {
			  "id": "1234",
			  "outputs": [
				{
				  "id": "4321"
				}
			  ]
			} 
			*/
        }

        public class OutputInfo
        {
            [JsonPropertyName("id")]
            public long Id { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }
    }
}