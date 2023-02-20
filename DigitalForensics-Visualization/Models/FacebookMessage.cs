using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DigitalForensics_Visualization.Models
{
    public class FacebookMessage
    {
        [JsonPropertyName("participants")]
        public List<Participant> Participants { get; set; }
        [JsonPropertyName("messages")]
        public List<Message> Messages { get; set; }
    }
}
