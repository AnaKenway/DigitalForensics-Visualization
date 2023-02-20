using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DigitalForensics_Visualization.Models
{
    public class GraphData
    {
        [JsonPropertyName("secondParticipant")]
        public string SecondParticipant { get; set; }
        [JsonPropertyName("numberOfMessages")]
        public int NumberOfMessages { get; set; }
    }
}
