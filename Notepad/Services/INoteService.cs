using Notepad.Models;

namespace Notepad.Services
{
    public interface INoteService
    {

        Task<Note> Get(int id);

        Task<IEnumerable<Note>> GetAll();

        Task Add(Note note);

        Task Delete(int id);

        Task Update(Note note);
    }
}
