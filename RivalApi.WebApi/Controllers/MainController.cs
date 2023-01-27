using Microsoft.AspNetCore.Mvc;

namespace RivalApi.WebApi.Controllers;

public class MainController : ControllerBase
{
    [HttpGet]
    [Route("GetString")]
    public string GetString()
    {
        return "method";
    }
}