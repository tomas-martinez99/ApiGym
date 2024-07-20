using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet] // Pedir Todas las clases disponibles
        public ActionResult<IEnumerable<ClassDto>> GetAllClass() {
            var clazz = _classService.GetAllClass();
            return Ok(clazz);
        }
        [HttpGet("{id}")] // Pedir una clase
        public ActionResult<ClassDto> GetClass([FromRoute]int id)
        {
            var clazz = _classService.GetByIdClass(id);
            if (clazz == null)
            {
                return NotFound();

            }
            return Ok(clazz);
        }
        [HttpPost] // Crear una clase
        public IActionResult CreateClass([FromBody]ClassDto classDto) { 
            _classService.CreateClass(classDto);
            return CreatedAtAction(nameof(GetClass), new {id = classDto.Id }, classDto);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateClass(int id, [FromBody]ClassDto classDto) { 
            if(id != classDto.Id)
            {
                return BadRequest();
            }
            _classService.UpdateClass(classDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClass(int id)
        {
            _classService.DeleteByIdClass(id);
            return NoContent();
        }
    }
}
