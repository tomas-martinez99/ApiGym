using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClubRepository
    {
       
        IEnumerable<Class> GetClasses();
        IEnumerable<Professor> GetProfessors();
        IEnumerable<Associate> GetAssociates();
    }
}
