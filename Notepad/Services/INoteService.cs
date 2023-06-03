using Notepad.Models;

namespace Notepad.Services
{
    public interface INoteService
    {

        Task<Note> Get(int id);

        Task GetAll(Note note);

        Task Add(Note note);

        Task Delete(int id);

        Task Update(Note note);
    }
}
