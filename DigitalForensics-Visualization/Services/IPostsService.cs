using DigitalForensics_Visualization.Models;
using System.Collections.Generic;

namespace DigitalForensics_Visualization.Services
{
    public interface IPostsService
    {
        public IEnumerable<Post> LoadPosts();
        //public IEnumerable<GraphData> LoadGraphData();
    }
}
