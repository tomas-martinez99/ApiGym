using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClassRepository
    {
        Class GetById(int id);
        IEnumerable<Class> GetAll();
        void add (Class clazz);
        void update (Class clazz);
        void delete (int id);
    }
}
