using Microsoft.AspNetCore.Mvc;

namespace handoff_api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet(Name = "GetHealth")]
    public IActionResult Get()
    {
        return Ok(new {
            Status = "Healthy"
        });
    }
}