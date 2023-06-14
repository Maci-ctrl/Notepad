using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public class NotebookContext : DbContext
    {
        public NotebookContext() 
        {

        }

        
        public NotebookContext(DbContextOptions<NotebookContext> options) : base(options)
        {

        }


        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(n => n.Id);
                entity.Property(n => n.Id).HasColumnName("Id").HasComment("PrimaryKey");
            });
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("NotepadContext");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
