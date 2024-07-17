using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Class { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<Associate> Associations { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

    }
}
