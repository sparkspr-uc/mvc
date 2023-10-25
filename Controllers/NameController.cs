using Microsoft.AspNetCore.Mvc;

namespace mvc.Controllers;

[ApiController]
[Route("[controller]")]
public class NameDataController : ControllerBase
{
    private readonly ILogger<NameDataController> _logger;

    public NameDataController(ILogger<NameDataController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetNameData")]
    public NameData Get()
    {
        return new NameData("Paul Sparks");
    }
}
