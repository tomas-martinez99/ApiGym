using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IProfesorService
    {
        IEnumerable<ProfessorDto> GetAllProfessor();
        ProfessorDto GetByIdProfessor(int id);
        void DeleteByIdProfessor(int id);
        void UpdateProfessor(ProfessorDto professorDto);
        void CreateProfessor(ProfessorDto professorDto);
        //Mostrar Las clases que da
    }
}
