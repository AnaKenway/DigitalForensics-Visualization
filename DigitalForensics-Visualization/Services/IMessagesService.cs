using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalForensics_Visualization.Models;

namespace DigitalForensics_Visualization.Services
{
    public interface IMessagesService
    {
        public IEnumerable<FacebookMessage> LoadFacebookMessages();
        public IEnumerable<GraphData> LoadGraphData();
    }
}
