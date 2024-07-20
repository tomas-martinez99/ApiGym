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
    public class AssociateService:IAssociateService
    {
        private readonly IAssocianteRepository _associanteRepository;
        public AssociateService(IAssocianteRepository associanteRepository)
        {
            _associanteRepository = associanteRepository;
        }

        public void CreateAssociate(AssociateDto associateDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdAssociate(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AssociateDto> GetAllAssociate()
        {
            throw new NotImplementedException();
        }

        public AssociateDto GetByIdAssociate(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAssociate(AssociateDto associateDto)
        {
            throw new NotImplementedException();
        }
    }
}
