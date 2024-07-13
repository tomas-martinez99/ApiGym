using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IProfessorRepository
    {
        Professor GetById(int id);
        IEnumerable<Professor> GetAll();
        void Add (Professor professor);
        void Update (Professor professor);
        void Delete (int id);
    }
}
