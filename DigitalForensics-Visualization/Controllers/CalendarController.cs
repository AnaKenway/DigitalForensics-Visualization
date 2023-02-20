using DigitalForensics_Visualization.Models;
using DigitalForensics_Visualization.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DigitalForensics_Visualization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : Controller
    {
            IPostsService _postsService;

            public CalendarController(IPostsService service)
            {
                _postsService = service;
            }

            [HttpGet]
            public IEnumerable<Post> Get()
            {
                return _postsService.LoadPosts();
            }
        }
    }
