using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IAssociateService
    {
        IEnumerable<AssociateDto> GetAllAssociate();
        AssociateDto GetByIdAssociate(int id);
        void DeleteByIdAssociate(int id);
        void UpdateAssociate(AssociateDto associateDto);
        void CreateAssociate(AssociateDto associateDto);
    }
}
