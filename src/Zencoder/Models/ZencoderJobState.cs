using System.Text.Json.Serialization;

namespace Zencoder.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ZencoderJobState
    {
        Unknown    = 0,
                   
        Waiting    = 1, // in&out
        Queued     = 2, // out
        Pending    = 3, // in
        Assigning  = 4, // in&out
        Processing = 5, // in&out
        Finished   = 6, // in&out
        Failed     = 7, // in&out
        Cancelled  = 8, // in&out

        Skipped    = 9,  // out
        No_Input   = 10, // out

        Ready      = 11 // ?
    }

    /// Input States:	waiting, pending, assigning, processing, finished, failed, cancelled.
    /// Output States:	waiting, queued, assigning, processing, finished, failed, cancelled, no input, and skipped.
}