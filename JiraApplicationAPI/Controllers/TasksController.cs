using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace JiraApplicationAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
 {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly ILogger<TasksController> _logger;

        public TasksController(ILogger<TasksController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTasks")]
        public IActionResult Get(int Id)
        {

            return Ok(new List<string>(Summaries.ToList()));
        }
    }
}
