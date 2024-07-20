using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Interfaces;

namespace Application.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;
        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public IEnumerable<ClassDto> GetAllClass()
        {
            var clazz = _classRepository.GetAll();

        }

        public ClassDto GetByIdClass(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteByIdClass(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateClass(ClassDto classDto)
        {
            throw new NotImplementedException();
        }

        public void CreateClass(ClassDto classDto)
        {
            throw new NotImplementedException();
        }

        private readonly 
    }
}
