using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TareasList.Core.Entities;
using TareasList.Infrastructure.Data.Configurations;

namespace TareasList.Infrastructure.Data
{
    public partial class TareaListContext : DbContext
    {
        public TareaListContext()
        {
        }

        public TareaListContext(DbContextOptions<TareaListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<User> Users { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");
            modelBuilder.ApplyConfiguration(new TareaConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());




        }

       
    }
}
