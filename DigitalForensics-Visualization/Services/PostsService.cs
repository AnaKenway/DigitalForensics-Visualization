using DigitalForensics_Visualization.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DigitalForensics_Visualization.Services
{
    public class PostsService : IPostsService
    {

        private readonly IConfiguration _configuration;
        public IList<Post> PostsList;
        public string AccountOwner = "Ana Milenkovic";
        public string DataJson = String.Empty;
        
        public PostsService(IConfiguration configuration)
        {
            _configuration = configuration;
            PostsList = new List<Post>();
        }
        public IEnumerable<Post> LoadPosts()
        {         
            using (StreamReader sr = new StreamReader(_configuration.GetValue<string>("DataPaths:PostsPath")))
            {
                string json = sr.ReadToEnd();
                PostsList = JsonConvert.DeserializeObject<IList<Post>>(json);
            }
            return PostsList;
        }  
    }
}
