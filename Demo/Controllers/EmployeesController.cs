using DemoUtils.StaitcUtils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            LogUtils.LogInformation(new Dictionary<string, string>() { { "Test", "tds" } });
            return "Test";
        }
    }
}