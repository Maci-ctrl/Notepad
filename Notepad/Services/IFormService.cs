using Notepad.Models;

namespace Notepad.Services
{
    public interface IFormService
    {
        Task<IEnumerable<Form>> GetAll();

        Task<Form> Get(int id);

        Task Add(string firstName, string lastName, string email, DateTime birthDate);

        Task Delete(int id);

        Task Update(Form form);



    }
}
