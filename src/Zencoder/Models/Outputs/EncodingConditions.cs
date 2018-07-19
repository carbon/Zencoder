using System.Runtime.Serialization;

namespace Zencoder.Models
{
    public class EncodeConditions
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
        [DataMember(Name = "min_size")]
        public string MinSize { get; set; }

        [DataMember(Name = "max_size")]
        public string MaxSize { get; set; }

        /// <summary>
        /// Skip output if the input file is shorter than the given duration, in seconds.
        /// </summary>
        [DataMember(Name = "min_duration")]
        public int? MinDuration { get; set; }

        /// <summary>
        /// Skip output if the input file is longer than the given duration, in seconds.
        /// </summary>
        [DataMember(Name = "max_duration")]
        public int? MaxDuration { get; set; }
    }
}
