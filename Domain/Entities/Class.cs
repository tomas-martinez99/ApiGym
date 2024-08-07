﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
         
        public DateTime Horary { get; set; }

        public int Ability { get; set; }

        public ICollection<Associate> Associates { get; set; }
        public ICollection<Professor> Professors { get; set; }
    }
}
