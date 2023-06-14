using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public static class DbInitializer
    {
        public static void InitializeAsync(NotebookContext context)
        {
            context.Database.EnsureCreated();

            if(context.Notes.Any())
            {
                return;
            }

            var notes = new Note[]
            {
                new Note("New Title1", "New Content1"),
                new Note("New Title2", "New Content2"),
                new Note("New Title3", "New Content3"),
                new Note("New Title4", "New Content4"),
            };

            foreach (Note n in notes)
            {
                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes ON");
                context.Notes.Add(n);
            }
            context.SaveChanges();

            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Notes OFF");



        }
    }
}
