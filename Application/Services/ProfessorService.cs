using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProfessorService : IProfesorService
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorService(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }

        public void CreateProfessor(ProfessorDto professorDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProfessorDto> GetAllProfessor()
        {
            throw new NotImplementedException();
        }

        public ProfessorDto GetByIdProfessor(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProfessor(ProfessorDto professorDto)
        {
            throw new NotImplementedException();
        }

    }
}
