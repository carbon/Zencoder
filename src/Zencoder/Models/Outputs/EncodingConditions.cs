#nullable disable

using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    public sealed class EncodeConditions
    {
        /*
		min_size		none	Skip output if the input file is smaller than the given dimensions.
		max_size		none	Skip output if the input file is larger than the given dimensions.
		min_duration	none	Skip output if the input file is shorter than the given duration, in seconds.
		max_duration	none	Skip output if the input file is longer than the given duration, in seconds.
		*/

        /// <summary>
        /// Skip output if the input file is smaller than the given dimensions.
        /// e.g. 640x480
        /// </summary>
        [JsonPropertyName("min_size")]
        public string MinSize { get; set; }

        [JsonPropertyName("max_size")]
        public string MaxSize { get; set; }

        /// <summary>
        /// Skip output if the input file is shorter than the given duration, in seconds.
        /// </summary>
        [JsonPropertyName("min_duration")]
        public int? MinDuration { get; set; }

        /// <summary>
        /// Skip output if the input file is longer than the given duration, in seconds.
        /// </summary>
        [JsonPropertyName("max_duration")]
        public int? MaxDuration { get; set; }
    }
}
