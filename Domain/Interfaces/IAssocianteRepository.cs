using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAssocianteRepository
    {
        Associate GetById(int id);
        IEnumerable<Associate> GetAll();
        void Add (Associate associate);
        void Update (Associate associate);
        void Delete (int id);
    }
}
