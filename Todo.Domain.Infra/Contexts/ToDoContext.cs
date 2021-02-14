using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }
        public DbSet<ToDoEntity> Todos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoEntity>().ToTable("Todo");
            modelBuilder.Entity<ToDoEntity>().Property(x => x.Id);
            modelBuilder.Entity<ToDoEntity>().Property(x => x.RefUser).HasMaxLength(120).HasColumnType("varchar(120)");
            modelBuilder.Entity<ToDoEntity>().Property(x => x.Title).HasMaxLength(160).HasColumnType("varchar(160)");
            modelBuilder.Entity<ToDoEntity>().Property(x => x.IsDone).HasColumnType("bit");
            modelBuilder.Entity<ToDoEntity>().Property(x => x.Date);
            modelBuilder.Entity<ToDoEntity>().HasIndex(b => b.RefUser);
        }
    }
}