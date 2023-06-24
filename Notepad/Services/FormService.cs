using Notepad.Models;

namespace Notepad.Services
{
    public class FormService : IFormService
    {
        public Task Add(string firstName, string lastName, string email, DateOnly birthDate)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Form> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Form>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Form form)
        {
            throw new NotImplementedException();
        }
    }
}
