using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class AssociateDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CompleteName { get => Name + " " + LastName; 

        public IList<ClassDto> ClassAttended { get; set; }= new List<ClassDto>();

        public static AssociateDto Create(Associate associate)
        {
            var dto = new AssociateDto();
            dto.Id = associate.Id;
            dto.UserName = associate.UserName;
            dto.Name = associate.Name;
            dto.LastName = associate.LastName;


            foreach (Class s in associate.ClassAttended)
            {
                dto.ClassAttended.Add(AssociateDto.Create(s));
            }

            return dto;
        }
    }
}
