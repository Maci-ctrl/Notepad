using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NotepadContext context)
        {
            context.Database.EnsureCreated();

            if(context.Notes.Any())
            {
                return;
            }

            var notes = new Note[]
            {
                new Note {Id = 1, Title = "Note 1 Title", Content = "Note 1 Content", DateCreated= new DateTime(2023,05,30,09,30,00), DateUpdated = new DateTime(2023,05,30,09,45,00)},
                new Note {Id = 2, Title = "Note 2 Title", Content = "Note 2 Content", DateCreated= new DateTime(2023,05,31,09,30,00), DateUpdated = new DateTime(2023,05,31,09,45,00)},
                new Note {Id = 3, Title = "Note 3 Title", Content = "Note 3 Content", DateCreated= new DateTime(2023,06,1,09,30,00), DateUpdated = new DateTime(2023,06,1,09,45,00)},
                new Note {Id = 4, Title = "Note 4 Title", Content = "Note 4 Content", DateCreated= new DateTime(2023,06,2,09,30,00), DateUpdated = new DateTime(2023,06,2,09,45,00)},
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
