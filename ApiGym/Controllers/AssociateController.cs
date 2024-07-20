using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateController : ControllerBase
    {
        private readonly IAssociateService _associateService;
        public AssociateController( IAssociateService associateService)
        {
            _associateService = associateService;
        }

        [HttpGet] 
        public ActionResult<IEnumerable<AssociateDto>> GetAll()
        {
            var associate = _associateService.GetAllAssociate();
            return Ok(associate);
        }
        [HttpGet("{id}")] 
        public ActionResult<AssociateDto> GetAssociate([FromRoute] int id)
        {
            var associate = _associateService.GetByIdAssociate(id);
            if (associate == null)
            {
                return NotFound();

            }
            return Ok(associate);
        }
        [HttpPost] 
        public IActionResult CreateAssociate([FromBody] AssociateDto associateDto)
        {
            _associateService.CreateAssociate(associateDto);
            return CreatedAtAction(nameof(GetAssociate), new { id = associateDto.Id }, associateDto);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateAssociate(int id, [FromBody] AssociateDto associateDto)
        {
            if (id != associateDto.Id)
            {
                return BadRequest();
            }
            _associateService.UpdateAssociate(associateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClass(int id)
        {
            _associateService.DeleteByIdAssociate(id);
            return NoContent();
        }




    }
}
