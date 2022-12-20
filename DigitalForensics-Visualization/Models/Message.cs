using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DigitalForensics_Visualization.Models
{
    public class Message
    {
        [JsonPropertyName("sender_name")]
        string SenderName { get; set; }

        [JsonPropertyName("timestamp_ms")]
        long Timestamp { get; set; }

        [JsonPropertyName("content")]
        string? Content { get; set; }

        [JsonIgnore]
        DateTime MessageTime { get; set; }
    }
}
