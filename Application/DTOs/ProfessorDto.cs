using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompleteName { get => Name + " " + LastName; }

        public static ProfessorDto Create(Professor professor)
        {
            var dto = new ProfessorDto();
            dto.Id = professor.Id;
            dto.UserName = professor.UserName;
            dto.Name = professor.Name;
            dto.LastName = professor.LastName;

            return dto;

        }
    }
}
