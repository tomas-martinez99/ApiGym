using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult<Class> Get([FromRoute] DateTime time, [FromRoute] string professor)
        {
            return Ok()
        }

    }
}
