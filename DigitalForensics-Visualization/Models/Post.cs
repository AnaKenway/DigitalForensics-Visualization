using Newtonsoft.Json;
using System;

namespace DigitalForensics_Visualization.Models
{
    public class Post
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonIgnore]
        public DateTime TimeOfPost { get => GetTimeFromTimestamp(); set => TimeOfPost = value; }

        private DateTime GetTimeFromTimestamp()
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(Timestamp);
            return dateTimeOffset.DateTime;
        }
    }
}
