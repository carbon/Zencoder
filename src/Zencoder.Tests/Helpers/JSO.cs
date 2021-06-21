using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zencoder
{
    internal static class JSO
    {
        public static readonly JsonSerializerOptions Default = new()
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };
    }
}