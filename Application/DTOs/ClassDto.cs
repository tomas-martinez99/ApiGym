using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ClassDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Horary {  get; set; }

        public string ProfesorName { get; set; }
        public int Ability { get; set; }
        public ICollection<Associate> Associates { get; set; }
    }
}
