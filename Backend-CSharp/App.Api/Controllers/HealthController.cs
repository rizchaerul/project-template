using App.Api.Models.Health;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public ActionResult<HealthResult> Get()
    {
        return Ok(new HealthResult { Status = "Healthy" });
    }
}
