using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DigitalForensics_Visualization.Models;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace DigitalForensics_Visualization.Pages
{
    public class MessagesModel : PageModel
    {
        private readonly IConfiguration _configuration;
        public IList<FacebookMessage> FacebookMessagesList;

        public MessagesModel(IConfiguration configuration)
        {
            _configuration = configuration;
            FacebookMessagesList = new List<FacebookMessage>();
        }
        public void OnGet()
        {
            foreach(string subDirpath in Directory.GetDirectories(_configuration.GetValue<string>("DataPaths:MessagesPath")))
            {
                foreach(string filePath in Directory.GetFiles(subDirpath))
                {
                    using(StreamReader sr = new StreamReader(filePath))
                    {
                        string json = sr.ReadToEnd();
                        FacebookMessagesList.Add(JsonConvert.DeserializeObject<FacebookMessage>(json));
                    }
                }
            }
            FacebookMessage fbm = FacebookMessagesList.First();
            string sender = fbm.Messages.First().SenderName;
        }
    }
}
