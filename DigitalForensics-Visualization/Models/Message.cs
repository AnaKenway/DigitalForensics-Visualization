using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace DigitalForensics_Visualization.Models
{
    public class Message
    {
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("timestamp_ms")]
        public long TimestampMs { get; set; }

        [JsonProperty("content")]
        public string? Content { get; set; }

        [JsonIgnore]
        public DateTime MessageTime { get => GetTimeFromTimestamp(); set => this.MessageTime = value; }

        private DateTime GetTimeFromTimestamp()
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(TimestampMs);
            return dateTimeOffset.DateTime;
        }
    }
}
