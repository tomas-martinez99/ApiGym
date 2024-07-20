using Application.DTOs;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfesorService _professorService;
        public ProfessorController(IProfesorService professorService)
        {
            _professorService = professorService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProfessorDto>> GetProfessors()
        {
            var professors = _professorService.GetAllProfessor();
            return Ok(professors);
        }

        [HttpGet("{id}")]
        public ActionResult<ProfessorDto> GetProfessor([FromRoute]int id)
        {
            var professor = _professorService.GetByIdProfessor(id);
            if (professor == null)
            {
                return NotFound();
            }
            return Ok(professor);
        }

        [HttpPost]
        public IActionResult CreateProfessor([FromBody] ProfessorDto professorDto)
        {
            _professorService.CreateProfessor(professorDto);
            return CreatedAtAction(nameof(GetProfessor), new { id = professorDto.Id }, professorDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProfesor(int id, [FromBody] ProfessorDto professorDto)
        {
            if (id != professorDto.Id)
            {
                return BadRequest();
            }
            _professorService.UpdateProfessor(professorDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProfesor(int id)
        {
            _professorService.DeleteByIdProfessor(id);
            return NoContent();
        }
    }
}
    }
}
