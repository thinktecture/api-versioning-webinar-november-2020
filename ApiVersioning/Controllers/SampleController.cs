using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Version()
        {
            return Ok("1");
        }
    }

    [ApiController]
    [Route("Sample")]
    [ApiVersion("2.0")]
    public class Sample2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Version()
        {
            return Ok("2");
        }
    }
}
