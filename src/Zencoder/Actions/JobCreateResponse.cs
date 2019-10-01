#nullable disable

using System;
using System.Runtime.Serialization;

using Carbon.Json;

namespace Zencoder.Models
{
    public class JobCreateResponse
    {
        public long Id { get; set; }

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
            [DataMember(Name = "id")]
            public long Id { get; set; }

            [DataMember(Name = "url")]
            public string Url { get; set; }
        }
    }
}