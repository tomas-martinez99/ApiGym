using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Club
    {
       public ICollection<Associate> Associates { get; set; } = new List<Associate>();
       public ICollection<Professor> Professors { get; set; } = new List<Professor>();
       [MaxLength(10)]
       public ICollection<Class> Classs { get; set; } = new List<Class>();
    }
}
