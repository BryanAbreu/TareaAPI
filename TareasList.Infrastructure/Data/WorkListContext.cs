using Microsoft.EntityFrameworkCore;
using TareasList.Core.Entities;

namespace TareasList.Infrastructure.Data
{
    public partial class WorkListContext : DbContext
    {
        public WorkListContext()
        {
        }

        public WorkListContext(DbContextOptions<WorkListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<User> Users { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkListContext).Assembly);
        }

       
    }
}
