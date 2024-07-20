using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClassService
    {
        IEnumerable<ClassDto> GetAllClass();
        ClassDto GetByIdClass(int id);
        void DeleteByIdClass(int id);
        void UpdateClass(ClassDto classDto);
        void CreateClass (ClassDto classDto);

        //Mostrar alumnos pertenecientes a la clase
        //Mostrar Profesor que da la clase
    }
}
