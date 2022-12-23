using DigitalForensics_Visualization.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalForensics_Visualization.Services
{
    public class MessagesService : IMessagesService
    {
        private readonly IConfiguration _configuration;
        public IList<FacebookMessage> FacebookMessagesList;
        public string AccountOwner = "Ana Milenkovic";
        public List<GraphData> GraphDataList;
        public string DataJson = String.Empty;

        public MessagesService(IConfiguration configuration)
        {
            _configuration = configuration;
            FacebookMessagesList = new List<FacebookMessage>();
            GraphDataList = new List<GraphData>();
        }
        public IEnumerable<FacebookMessage> LoadFacebookMessages()
        {
            foreach (string subDirpath in Directory.GetDirectories(_configuration.GetValue<string>("DataPaths:MessagesPath")))
            {
                foreach (string filePath in Directory.GetFiles(subDirpath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string json = sr.ReadToEnd();
                        FacebookMessage msg = JsonConvert.DeserializeObject<FacebookMessage>(json);
                        FacebookMessagesList.Add(msg);
                        GraphDataList.Add(new GraphData
                        {
                            SecondParticipant = msg.Participants.Select(n => n.Name.Trim()).Where(n => !n.Equals(AccountOwner)).FirstOrDefault(),
                            NumberOfMessages = msg.Messages.Count
                        });
                    }
                }
            }
            return FacebookMessagesList;
        }
    }
}
