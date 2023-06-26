using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public class FormContext : DbContext
    {
        public FormContext()
        {

        }

        public FormContext(DbContextOptions<FormContext> options) : base(options)
        {

        }


        public DbSet<Form> Forms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).HasColumnName("Id").HasComment("PrimaryKey");
            });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("NotepadContext");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
