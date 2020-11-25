using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning
{
    [ApiController]
    [Route("[controller]")]
    [ApiVersion("1.0"), ApiVersion("2.0")]
    public class ExampleController : ControllerBase
    {
        [HttpGet("Version")]
        [MapToApiVersion("1.0")]
        public ActionResult<string> Version()
        {
            return Ok("1");
        }

        [HttpGet("Version")]
        [MapToApiVersion("2.0")]
        public ActionResult<string> Version2()
        {
            return Ok("2");
        }

        [HttpGet("Test")]
        [MapToApiVersion("1.0"), MapToApiVersion("2.0")]
        public ActionResult<string> Test(ApiVersion version)
        {
            return Ok(version.ToString());
        }
    }
}
