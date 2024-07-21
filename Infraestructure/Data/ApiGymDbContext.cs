using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infraestructure.Data
{
    public class ApiGymDbContext : DbContext
    {
        public ApiGymDbContext(DbContextOptions<ApiGymDbContext> options)
            : base(options) { }
    }

    public DbSet<User> Users {  get; set; }
    public DbSet<Professor> Professors {  get; set; }
    public DbSet<Class> Classes {  get; set; }
    public DbSet<Associate> Associates {  get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Config de Herencia

        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType")
            .HasValue<Professor>("Professor")
            .HasValue<Associate>("Associate");

        //Config Relacion muchos a muchos

        modelBuilder.Entity<Class>()
            .HasMany(p => p.Professors)
            .WithMany(c => c.Class)
            .UsingEntity(j => j.ToTable("ClassProfessors"));

        modelBuilder.Entity<Class>()
            .HasMany(c => c.Associates)
            .WithMany(a => a.ClassAttended)
            .UsingEntity(j => j.ToTable("ClassAssociates"));
    }


}
