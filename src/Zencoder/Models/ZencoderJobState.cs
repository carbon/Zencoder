namespace Zencoder.Models
{
    public enum ZencoderJobState
    {
        Unknown = 0,

        Waiting,    // in&out
        Queued,     // out
        Pending,    // in
        Assigning,  // in&out
        Processing, // in&out
        Finished,   // in&out
        Failed,     // in&out
        Cancelled,  // in&out

        Skipped,    // out
        No_Input,   // out

        Ready       // ?
    }

    /// Input States:	waiting, pending, assigning, processing, finished, failed, cancelled.
    /// Output States:	waiting, queued, assigning, processing, finished, failed, cancelled, no input, and skipped.
}