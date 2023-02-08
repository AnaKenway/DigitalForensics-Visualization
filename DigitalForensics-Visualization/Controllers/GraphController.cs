using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DigitalForensics_Visualization.Services;
using DigitalForensics_Visualization.Models;


namespace DigitalForensics_Visualization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphController : ControllerBase
    {
        IMessagesService _messagesService;

        public GraphController(IMessagesService service)
        {
            _messagesService = service;
        }

        [HttpGet]
        public IEnumerable<GraphData> Get()
        {
            return _messagesService.LoadGraphData();
        }
    }
}
