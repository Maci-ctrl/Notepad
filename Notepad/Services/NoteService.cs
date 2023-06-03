using Microsoft.EntityFrameworkCore;
using Notepad.Data;
using Notepad.Models;

namespace Notepad.Services
{
    public class NoteService : INoteService
    {
        private readonly NotepadContext _context;

        public NoteService(NotepadContext context)
        {
            _context = context;
        }

        public async Task Add(Note note)
        {
            
            await _context.Notes.AddAsync(note);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var note = await Get(id);

            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Note> Get(int id)
        {
            var x = await _context.Notes.FirstOrDefaultAsync(n => n.Id == id);
            return x;
        }

        public async Task<IEnumerable<Note>> GetAll()
        {
            return await _context.Notes.OrderBy(n => n.Title).ToListAsync();
        }

        public async Task Update(Note note)
        {
            var existingNote = await Get(note.Id);

            if (existingNote != null)
            {
                existingNote.Title = note.Title;
                existingNote.Content = note.Content;
                existingNote.DateUpdated = note.DateUpdated;
                await _context.SaveChangesAsync();
            }
        }
    }
}
