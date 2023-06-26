using Microsoft.EntityFrameworkCore;
using Notepad.Data;
using Notepad.Models;

namespace Notepad.Services
{
    public class FormService : IFormService
    {
        private readonly FormContext _context;

        public async Task Add(string firstName, string lastName, string email, DateOnly birthDate)
        {
            Form form = new Form(firstName,lastName,email,birthDate);

            await _context.Forms.AddAsync(form);

            await _context.SaveChangesAsync();
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
